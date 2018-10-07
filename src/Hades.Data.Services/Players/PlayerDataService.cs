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

        public PlayerDataService(IDataContextProvider dataContextProvider, IPlayerCache playerCache)
        {
            _contextProvider = dataContextProvider;
            _playerCache = playerCache;
        }

        public async Task<Player> GetPlayer(long id)
        {
            using (var context = _contextProvider.GetContext())
            {
                return await _playerCache.Get(id, async (playerId) => {
                    return new Player
                    {
                        Data = await context.PlayerRepository.GetPlayerById(playerId)
                    };
                });
            }
        }
    }
}
