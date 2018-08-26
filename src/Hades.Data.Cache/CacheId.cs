using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    public sealed class CacheId<T>
    {
        public CacheId(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
