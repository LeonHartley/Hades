using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cache.Players
{
    public class PlayerCache : CacheBase<long, Player>, IPlayerCache
    {
        public PlayerCache(ICache<long, Player> internalCache) : base(internalCache)
        {
        }
    }
}
