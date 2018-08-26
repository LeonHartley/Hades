using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Hades.Data.Cache
{
    public class RedisCache<T> : ICache<T> where T : ICacheItem
    {
        private readonly IDatabaseAsync _db;
        private readonly string _keyFormat = nameof(T) + "-{0}";

        public RedisCache(CacheId<T> cacheId, IDatabaseAsync database)
        {
            Id = cacheId;
            _db = database;
        }
        
        public CacheId<T> Id { get; }

        public async Task<bool> Add(T cacheItem)
        {
            var data = JsonConvert.SerializeObject(cacheItem);

            return await _db.StringSetAsync(string.Format(_keyFormat, cacheItem.Id), data);
        }

        public async Task<T> Get(long id)
        {
            var result = await _db.StringGetAsync(string.Format(_keyFormat, id));
            var obj = JsonConvert.DeserializeObject<T>(result.ToString());

            return obj;
        }

        public async Task<bool> Remove(long id)
        {
            return await _db.KeyDeleteAsync(string.Format(_keyFormat, id));
        }

        public async Task<bool> Update(T cacheItem)
        {
            return await Add(cacheItem);
        }
    }
}
