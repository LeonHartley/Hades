using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace Hades.Common.Cache
{
    class RedisConnectionProvider : IRedisConnectionProvider
    {
        private readonly RedisCacheOptions _redisCacheOptions;
        private ConnectionMultiplexer _connectionMultiplexer;

        public RedisConnectionProvider(RedisCacheOptions redisCacheOptions)
        {
            _redisCacheOptions = redisCacheOptions;
        }

        public ConnectionMultiplexer GetConnection()
        {
            if(_connectionMultiplexer == null)
            {
                _connectionMultiplexer = ConnectionMultiplexer.Connect(string.Format("{0}:{1}", _redisCacheOptions.Host, _redisCacheOptions.Port));
            }

            return _connectionMultiplexer;
        }
    }
}
