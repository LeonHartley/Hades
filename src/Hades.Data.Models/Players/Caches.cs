using Hades.Data.Cache;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Model.Players
{
    public class Caches
    {
        public static CacheId<Player> PlayerCache = new CacheId<Player>("Hades.Caches.PlayerCache");
    }
}
