using System.Threading.Tasks;
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

        public async Task<PlayerData> GetPlayerData(long id)
        {
            return await _playerDataService.GetPlayerData(id);
        }
    }
}
