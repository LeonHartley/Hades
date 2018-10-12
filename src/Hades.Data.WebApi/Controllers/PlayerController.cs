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
        private readonly IPlayerDataProcessor _playerDataProcessor;
        private readonly IPlayerAuthenticationProcessor _playerAuthenticationProcessor;

        public PlayerController(
            IPlayerDataProcessor playerDataProcessor,
            IPlayerAuthenticationProcessor playerAuthenticationProcessor)
        {
            _playerDataProcessor = playerDataProcessor;
            _playerAuthenticationProcessor = playerAuthenticationProcessor;
        }

        [HttpGet]
        [Route("data/{playerId}")]
        public async Task<IActionResult> GetPlayerData([FromRoute] long playerId)
        {
            try
            {
                return Ok(new ServerResponse<PlayerData>
                {
                    Data = await _playerDataProcessor.GetPlayerData(playerId)
                });
            }
            catch (PlayerDataException e)
            {
                return NotFound(new ServerResponse<PlayerData>
                {
                    Success = false,
                    Error = e.Error.ToString()
                });
            }
        }

        [HttpGet]
        [Route("{playerId}")]
        public async Task<IActionResult> GetPlayer([FromRoute] long playerId)
        {
            try
            {
                return Ok(new ServerResponse<Player>
                {
                    Data = await _playerDataProcessor.GetPlayer(playerId)
                });
            }
            catch (PlayerDataException e)
            {
                return NotFound(new ServerResponse<Player>
                {
                    Success = false,
                    Error = e.Error.ToString()
                });
            }
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
                    Error = e.Error.ToString()
                });
            }
        }
    }
}