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
            throw new NotImplementedException();
        }

        public Task<TVal> Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(TKey key)
        {
            throw new NotImplementedException();
        }
    }
}
