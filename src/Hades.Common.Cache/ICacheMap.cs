using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Common.Cache
{
    public interface ICacheMap<TKey, TVal>
    {
        Task<TVal> Get(TKey key);

        Task<bool> Remove(TKey key);

        Task<bool> Add(TKey key, TVal val);
    }
}
