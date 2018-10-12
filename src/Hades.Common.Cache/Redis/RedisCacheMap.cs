using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Common.Cache.Redis
{
    public class RedisCacheMap<TKey, TVal> : ICacheMap<TKey, TVal>
    {
        private readonly IDatabaseAsync _database;

        public RedisCacheMap(string mapName, IDatabaseAsync database)
        {
            _database = database;
        }

        public Task<bool> Add(TKey key, TVal val)
        {
            return Task.FromResult(true);
        }

        public Task<MapResult<TVal>> Get(TKey key)
        {
            return Task.FromResult(new MapResult<TVal>(false, default(TVal)));
        }

        public Task<bool> Remove(TKey key)
        {
            return Task.FromResult(true);
        }
    }
}
