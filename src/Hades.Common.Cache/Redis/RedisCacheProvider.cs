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

        public ICache<TKey, TVal> GetCache<TKey, TVal>(CacheId<TKey, TVal> cacheId)
        {
            var database = _databaseProvider.GetDatabase();

            return new RedisCache<TKey, TVal>(database);
        }
    }
}
