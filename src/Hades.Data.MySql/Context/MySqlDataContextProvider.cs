using Hades.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.MySql.Context
{
    public class MySqlDataContextProvider : IDataContextProvider
    {
        private readonly IConnectionProvider _connectionProvider;

        public MySqlDataContextProvider(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public IDataContext GetContext()
        {
            var mysqlConnection = _connectionProvider.GetConnection();
            return new MySqlDataContext(mysqlConnection, mysqlConnection.BeginTransaction());
        }
    }
}
