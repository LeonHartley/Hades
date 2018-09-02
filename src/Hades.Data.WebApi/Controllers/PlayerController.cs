using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hades.Data.Model.Players;
using Hades.Data.Repositories.Services;
using Hades.Data.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace Hades.Data.WebApi.Controllers
{
    [Route("api/v1/player")]
    [ApiController]
    public class PlayerController : ApiController
    {
        private IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        
        [HttpGet]
        [Produces("application/json")]
        [Route("authenticate/{ssoTicket}")]
        public async Task<IActionResult> Authenticate([FromRoute] string ssoTicket)
        {
            var player = await _playerService.Authenticate(ssoTicket);
            var res = new ServerResponse<Player>
            {
                Data = player,
                Success = player != null
            };

            if(player == null)
            {
                return NotFound(res);
            }
            else
            {
                return Ok(res);
            }
        }
    }
}
