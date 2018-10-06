using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    public interface ICacheMapProvider
    {
        ICacheMap<TKey, TVal> GetMap<TKey, TVal>(CacheId<object> id);
    }
}
