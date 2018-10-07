using Hades.Common.Cache;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache.Maps
{
    public interface IMapStore<TKey, TVal>
    {
        Task<MapResult<TVal>> GetAsync(TKey key);

        Task<bool> RemoveAsync(TKey key);

        Task<bool> AddAsync(TKey key, TVal val);
    }
}
