using Hades.Data.Repositories;
using Hades.Data.Services.Interfaces;
using System.Threading.Tasks;
using Hades.Data.Model.Players;
using Hades.Data.Cache.Interfaces;

namespace Hades.Data.Services.Players
{
    public class PlayerDataService : IPlayerDataService
    {
        private readonly IDataContextProvider _contextProvider;
        private readonly IPlayerCache _playerCache;
        private readonly IPlayerDataCache _playerDataCache;

        public PlayerDataService(
            IDataContextProvider dataContextProvider,
            IPlayerCache playerCache,
            IPlayerDataCache playerDataCache)
        {
            _contextProvider = dataContextProvider;
            _playerCache = playerCache;
            _playerDataCache = playerDataCache;
        }

        public async Task<Player> GetPlayer(long id)
        {
            using (var context = _contextProvider.GetContext())
            {
                return await _playerCache.Get(id, context, async (playerId, ctx) => new Player
                {
                    Id = id,
                    Data = await ctx.PlayerRepository.GetPlayerById(playerId),
                    Badges = await ctx.InventoryRepository.GetBadges(playerId),
                    Friends = await ctx.MessengerRepository.GetFriendships(playerId)
                });
            }
        }

        public async Task<PlayerData> GetPlayerData(long id)
        {
            using (var context = _contextProvider.GetContext())
            {
                return await _playerDataCache.Get(id, context,
                    async (playerId, ctx) => await ctx.PlayerRepository.GetPlayerById(playerId));
            }
        }
    }
}