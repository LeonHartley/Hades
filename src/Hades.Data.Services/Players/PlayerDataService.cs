using System.Runtime.InteropServices.ComTypes;
using Hades.Data.Repositories;
using Hades.Data.Services.Interfaces;
using System.Threading.Tasks;
using Hades.Data.Cache;
using Hades.Data.Model.Players;

namespace Hades.Data.Services.Players
{
    public class PlayerDataService : IPlayerDataService
    {
        private IDataContextProvider _contextProvider;
        private ICache<Player> _playerCache;

        public PlayerDataService(ICache<Player> playerCache, IDataContextProvider dataContextProvider)
        {
            _contextProvider = dataContextProvider;
            _playerCache = playerCache;
        }

        public async Task<Player> GetPlayer(long id)
        {
            using (var context = _contextProvider.GetContext())
            {
                var player = await _playerCache.Get(id);

                if (player != null)
                {
                    return player;
                }
                
                var player = return new Player
                {
                    Data = await context.PlayerRepository.GetPlayerById(id)
                };
            }
        }
    }
}
