using System;
using System.Threading.Tasks;
using Hades.Data.Exceptions;
using Hades.Data.Exceptions.Errors;
using Hades.Data.Model.Players;
using Hades.Data.Processors.Interfaces;
using Hades.Data.Services.Interfaces;

namespace Hades.Data.Processors.Players
{
    public class PlayerDataProcessor : IPlayerDataProcessor
    {
        private readonly IPlayerDataService _playerDataService;

        public PlayerDataProcessor(IPlayerDataService playerDataService)
        {
            _playerDataService = playerDataService;
        }

        public async Task<Player> GetPlayer(long id)
        {
            var player = await _playerDataService.GetPlayer(id);

            if (player == null)
            {
                throw new PlayerDataException(PlayerDataError.NotFound);
            }

            return player;
        }
        
        public async Task<PlayerData> GetPlayerData(long id)
        {
            var player = await _playerDataService.GetPlayerData(id);

            if (player == null)
            {
                throw new PlayerDataException(PlayerDataError.NotFound);
            }

            return player;
        }
    }
}
