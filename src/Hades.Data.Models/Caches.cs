using Hades.Common.Cache;
using System;
using System.Collections.Generic;
using System.Text;
using Hades.Data.Model.Players;

namespace Hades.Data.Model
{
    public class Caches
    {
        public static CacheId<long, Player> PlayerCache = new CacheId<long, Player>();
    }
}
