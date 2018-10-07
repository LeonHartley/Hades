using Hades.Data.MySql.Repositories;
using Hades.Data.Repositories;
using Hades.Data.Repositories.Players;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Hades.Data.MySql.Context
{
    public class MySqlDataContext : IDataContext
    {
        private readonly MySqlTransaction _transaction;

        private IPlayerRepository _playerRepository;
        private IMessengerRepository _messengerRepository;

        public MySqlDataContext(MySqlConnection connection, MySqlTransaction transaction)
        {
            Connection = connection;
            _transaction = transaction;
        }

        public MySqlConnection Connection { get; }

        public IPlayerRepository PlayerRepository => _playerRepository ?? (_playerRepository = new PlayerRepository(this));

        public IMessengerRepository MessengerRepository => _messengerRepository ?? (_messengerRepository = new MessengerRepository(this));

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
            Connection.Dispose();
        }
    }
}
