using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache
{
    public abstract class CacheBase<TKey, TVal> : IObjectCache<TKey, TVal>
    {
        private ICache<TKey, TVal> _internalCache;

        public CacheBase(ICache<TKey, TVal> internalCache)
        {
            _internalCache = internalCache;
        }

        public async Task<TVal> Get(TKey key, Func<TKey, Task<TVal>> loader)
        {
            var item = await _internalCache.Get(key);

            if(item != null)
            {
                return item;
            }

            item = await loader.Invoke(key);
            
            if(item != null)
            {
                _internalCache.Add(key, item);
            }

            return item;
        }
    }
}
