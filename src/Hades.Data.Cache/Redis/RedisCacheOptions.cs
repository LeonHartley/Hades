﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    public sealed class RedisCacheOptions
    {
        public string Host { get; set; }

        public short  Port { get; set; }
    }
}
