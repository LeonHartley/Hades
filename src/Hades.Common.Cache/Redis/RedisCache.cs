using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Hades.Common.Cache
{
    public class RedisCache<TKey, TVal> : ICache<TKey, TVal>
    {
        private readonly IDatabaseAsync _db;
        private readonly string _keyFormat = nameof(TVal) + "-{0}";

        public RedisCache(IDatabaseAsync database)
        {
            _db = database;
        }
        
        public async Task<bool> Add(TKey key, TVal cacheItem)
        {
            var data = JsonConvert.SerializeObject(cacheItem);

            return await _db.StringSetAsync(string.Format(_keyFormat, key), data);
        }

        public async Task<TVal> Get(TKey id)
        {
            var result = await _db.StringGetAsync(string.Format(_keyFormat, id));

            if(result.HasValue)
            {
                return JsonConvert.DeserializeObject<TVal>(result.ToString());
            }

            return default(TVal);
        }

        public async Task<bool> Remove(TKey id)
        {
            return await _db.KeyDeleteAsync(string.Format(_keyFormat, id));
        }

        public async Task<bool> Update(TKey key, TVal cacheItem)
        {
            return await Add(key, cacheItem);
        }
    }
}
