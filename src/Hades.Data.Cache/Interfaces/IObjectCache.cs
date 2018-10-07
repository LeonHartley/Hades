using Hades.Common.Cache;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache.Interfaces
{
    public interface IObjectCache<TKey, TObj>
    {
        Task<TObj> Get(TKey key, Func<TKey, Task<TObj>> loader);
    }
}
