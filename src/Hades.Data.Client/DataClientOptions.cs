using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Client
{
    public sealed class DataClientOptions
    {
        public string HttpApiUrl { get; }
        
        public string HttpApiSecret { get; }

        public string RedisHost { get; }

        public short RedisPort { get; }
    }
}
