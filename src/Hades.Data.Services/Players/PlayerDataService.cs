using Hades.Data.Repositories;
using Hades.Data.Services.Interfaces;
using System.Threading.Tasks;
using Hades.Data.Model.Players;
using Hades.Data.Cache.Interfaces;

namespace Hades.Data.Services.Players
{
    public class PlayerDataService : IPlayerDataService
    {
        private IDataContextProvider _contextProvider;
        private IPlayerCache _playerCache;
        private IPlayerDataCache _playerDataCache;

        public PlayerDataService(
            IDataContextProvider dataContextProvider,
            IPlayerCacheProvider playerCacheProvider, 
            IPlayerDataCacheProvider playerDataCacheProvider)
        {
            _contextProvider = dataContextProvider;
            _playerCache = playerCacheProvider.GetCache();
            _playerDataCache = playerDataCacheProvider.GetCache();
        }

        public async Task<Player> GetPlayer(long id)
        {
            using (var context = _contextProvider.GetContext())
            {
                return await _playerCache.Get(id, async playerId => new Player
                {
                    Id = id,
                    Data = await context.PlayerRepository.GetPlayerById(playerId)
                });
            }
        }

        public async Task<PlayerData> GetPlayerData(long id)
        {
            using (var context = _contextProvider.GetContext())
            {
                return await _playerDataCache.Get(id, 
                    async playerId => await context.PlayerRepository.GetPlayerById(playerId));
            }
        }
    }
}
