using Hades.Common.Cache;
using Hades.Data.Cache.Maps;
using System;
using System.Collections.Generic;
using System.Text;
using Hades.Data.Cache.Interfaces;

namespace Hades.Data.Cache.Players
{
    public class PlayerTokenStore : MapStoreBase<string, long>, IPlayerTokenStore
    {
        public PlayerTokenStore(ICacheMap<string, long> internalMap) : base(internalMap)
        {
        }
    }
}
