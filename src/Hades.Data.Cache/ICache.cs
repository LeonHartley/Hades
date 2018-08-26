using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache
{
    public interface ICache<T> where T : ICacheItem
    {
        CacheId<T> Id { get; }

        Task<bool> Add(T cacheItem);

        Task<bool> Remove(long id);

        Task<bool> Update(T cacheItem);

        Task<T> Get(long id);
    }
}
