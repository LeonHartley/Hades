using Hades.Common.Cache;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache.Players
{
    public class PlayerDataCache : CacheBase<long, PlayerData>, IPlayerDataCache
    {
        public PlayerDataCache(ICache<long, PlayerData> internalCache) : base(internalCache)
        {

        }
    }
}