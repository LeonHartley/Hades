using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Common.Cache
{
    class RedisDatabaseProvider : IRedisDatabaseProvider
    {
        private readonly IRedisConnectionProvider _connectionProvider;

        public RedisDatabaseProvider(IRedisConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public IDatabaseAsync GetDatabase()
        {
            var connection = _connectionProvider.GetConnection();

            return connection.GetDatabase();
        }
    }
}
