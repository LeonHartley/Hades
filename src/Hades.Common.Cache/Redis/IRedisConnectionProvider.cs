using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Common.Cache
{
    public interface IRedisConnectionProvider
    {
        ConnectionMultiplexer GetConnection();
    }
}
