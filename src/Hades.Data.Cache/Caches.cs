using Hades.Common.Cache;
using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    internal class Caches
    {
        public static CacheId<long, Player> PlayerCache = new CacheId<long, Player>();

        public static CacheId<long, PlayerData> PlayerDataCache = new CacheId<long, PlayerData>();
    }
}
