using System;
using System.Threading.Tasks;
using Hades.Data.Repositories;

namespace Hades.Data.Cache.Interfaces
{
    public interface IObjectCache<TKey, TObj>
    {
        Task<TObj> Get(TKey key, IDataContext ctx, Func<TKey, IDataContext, Task<TObj>> loader);
    }
}
