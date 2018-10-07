using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Cache.Maps;
using Hades.Data.Cache.Players;

namespace Hades.Data.Cache.Providers
{
    public class PlayerTokenStoreProvider : IPlayerTokenStoreProvider
    {
        private readonly ICacheMapProvider _cacheMapProvider;

        public PlayerTokenStoreProvider(ICacheMapProvider cacheMapProvider)
        {
            _cacheMapProvider = cacheMapProvider;
        }

        public IPlayerTokenStore GetTokenStore()
        {
            return new PlayerTokenStore(_cacheMapProvider.GetMap<string, long>("playerTokenStore"));
        }
    }
}