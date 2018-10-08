using Hades.Common.Cache;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache.Maps
{
    public interface IMapStore<TKey, TVal>
    {
        Task<MapResult<TVal>> Get(TKey key);

        Task<bool> Remove(TKey key);

        Task<bool> Add(TKey key, TVal val);
    }
}
