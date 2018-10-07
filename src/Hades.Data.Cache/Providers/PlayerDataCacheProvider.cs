using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Cache.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache.Providers
{
    public class PlayerDataCacheProvider
    {
        private ICacheProvider _cacheProvider;

        public PlayerDataCacheProvider(ICacheProvider cacheProvider)
        {
            _cacheProvider = cacheProvider;
        }
        public IPlayerDataCache GetCache()
        {
            return new PlayerDataCache(_cacheProvider.GetCache(Caches.PlayerDataCache));
        }
    }
}
