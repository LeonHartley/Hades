using Hades.Data.Cache;
using Hades.Data.Exceptions;
using Hades.Data.Model.Players;
using Hades.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Processors
{
    public class PlayerDataProcessor : IPlayerDataProcessor
    {
        private readonly ICacheMap<string, long> _playerAuthStore;
        private readonly ICache<Player> _playerDataCache;
        private readonly IDataContextProvider _dataContextProvider;

        public PlayerDataProcessor(
            ICacheMapProvider cacheMapProvider,
            IDataContextProvider dataContextProvider)
        {
            _playerAuthStore = cacheMapProvider.GetMap<string, long>(new CacheId<object>("PlayerAuthenticationStore"));
        }

        public async Task<Player> Authenticate(string authenticationToken)
        {
            var playerId = await _playerAuthStore.Get(authenticationToken);

            if(playerId == 0)
            {
                throw new PlayerAuthenticationException("No player ID found in authentication store");
            }

            using (IDataContext ctx = _dataContextProvider.GetContext())
            {
                return new Player
                {
                    Data = await ctx.PlayerRepository.GetPlayerById(playerId)
                };
            }
        }
    }
}
