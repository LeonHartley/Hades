﻿using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Repositories;

namespace Hades.Data.Cache
{
    public abstract class CacheBase<TKey, TVal> : IObjectCache<TKey, TVal>
    {
        private readonly ICache<TKey, TVal> _internalCache;

        protected CacheBase(ICache<TKey, TVal> internalCache)
        {
            _internalCache = internalCache;
        }

        public async Task<TVal> Get(TKey key, IDataContext ctx, Func<TKey, IDataContext, Task<TVal>> loader)
        {
            var item = await _internalCache.Get(key);

            if(item != null)
            {
                return item;
            }

            item = await loader.Invoke(key, ctx);
            
            if(item != null)
            {
                await _internalCache.Add(key, item);
            }

            return item;
        }
    }
}
