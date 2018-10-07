using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.MySql
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private readonly MySqlDataOptions _options;

        public ConnectionStringProvider(MySqlDataOptions options)
        {
            _options = options;
        }

        public string ConnectionString => _options.ConnectionString;
    }
}
