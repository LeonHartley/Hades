using Hades.Data.Repositories;
using Hades.Data.Repositories.Players;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Hades.Data.MySql.Context
{
    public class MySqlDataContext : IDataContext
    {
        private readonly MySqlConnection _connection;
        private readonly MySqlTransaction _transaction;

        public MySqlDataContext(
            MySqlConnection connection,
            MySqlTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public IPlayerRepository PlayerRepository => throw new NotImplementedException();

        public IMessengerRepository MessengerRepository => throw new NotImplementedException();

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _transaction.Dispose();
            _connection.Dispose();
        }
    }
}
