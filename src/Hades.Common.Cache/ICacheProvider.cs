﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Common.Cache
{
    public interface ICacheProvider
    {
        ICache<T> GetCache<T>(CacheId<T> cacheId) where T : ICacheItem;
    }
}