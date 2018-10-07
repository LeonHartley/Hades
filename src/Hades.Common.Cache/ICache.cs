using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Common.Cache
{
    public interface ICache<TKey, TVal>
    {
        Task<bool> Add(TKey key, TVal cacheItem);

        Task<bool> Remove(TKey key);

        Task<bool> Update(TKey key, TVal cacheItem);

        Task<TVal> Get(TKey id);
    }
}
