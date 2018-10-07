using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Hades.Data.MySql
{
    public class MySqlConnectionProvider : IConnectionProvider
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        
        public MySqlConnectionProvider(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(_connectionStringProvider.ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
