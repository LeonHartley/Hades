using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Cache.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache.Providers
{
    public class PlayerCacheProvider : IPlayerCacheProvider
    {
        private ICacheProvider _cacheProvider;

        public PlayerCacheProvider(ICacheProvider cacheProvider)
        {
            _cacheProvider = cacheProvider;
        }
        public IPlayerCache GetCache()
        {
            return new PlayerCache(_cacheProvider.GetCache(Caches.PlayerCache));
        }
    }
}
