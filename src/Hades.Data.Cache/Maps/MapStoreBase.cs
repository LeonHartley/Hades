using Hades.Common.Cache;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache.Maps
{
    public abstract class MapStoreBase<TKey, TVal> : IMapStore<TKey, TVal>
    {
        private readonly ICacheMap<TKey, TVal> _internalMap;
        
        protected MapStoreBase(ICacheMap<TKey, TVal> internalMap)
        {
            _internalMap = internalMap;
        }

        public async Task<bool> Add(TKey key, TVal val)
        {
            return await _internalMap.Add(key, val);
        }

        public async Task<MapResult<TVal>> Get(TKey key)
        {
            return await _internalMap.Get(key);
        }

        public async Task<bool> Remove(TKey key)
        {
            return await _internalMap.Remove(key);
        }
    }
}
