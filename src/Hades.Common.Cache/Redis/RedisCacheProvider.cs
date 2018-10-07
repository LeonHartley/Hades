using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Common.Cache
{
    public class RedisCacheProvider : ICacheProvider
    {
        private readonly IRedisDatabaseProvider _databaseProvider;

        public RedisCacheProvider(IRedisDatabaseProvider databaseProvider, RedisCacheOptions options)
        {
            _databaseProvider = databaseProvider;
        }

        public ICache<T> GetCache<T>(CacheId<T> cacheId) where T : ICacheItem
        {
            var database = _databaseProvider.GetDatabase();

            return new RedisCache<T>(cacheId, database);
        }
    }
}
