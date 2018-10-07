using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Common.Cache
{
    public interface ICacheProvider
    {
        ICache<TKey, TVal> GetCache<TKey, TVal>(CacheId<TKey, TVal> cacheId);
    }
}
