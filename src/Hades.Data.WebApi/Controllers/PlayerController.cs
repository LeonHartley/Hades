using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hades.Data.Exceptions;
using Hades.Data.Model.Players;
using Hades.Data.Processors.Interfaces;
using Hades.Data.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace Hades.Data.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/player")]
    [Produces("application/json")]
    public class PlayerController : ApiController
    {
        private IPlayerAuthenticationProcessor _playerAuthenticationProcessor;

        public PlayerController(IPlayerAuthenticationProcessor playerAuthenticationProcessor)
        {
            _playerAuthenticationProcessor = playerAuthenticationProcessor;
        }
        
        [HttpGet]
        [Route("authenticate/{ssoTicket}")]
        public async Task<IActionResult> Authenticate([FromRoute] string ssoTicket)
        {
            try
            {
                return Ok(new ServerResponse<Player>
                {
                    Data = await _playerAuthenticationProcessor.GetPlayer(ssoTicket),
                    Success = true
                });
            }
            catch (PlayerAuthenticationException e)
            {
                return NotFound(new ServerResponse<Player>
                {
                    Success = false,
                    Error = e.Error
                });
            }
        }
    }
}
