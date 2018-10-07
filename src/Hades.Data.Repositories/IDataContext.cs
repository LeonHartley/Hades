using Hades.Data.Repositories.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Repositories
{
    public interface IDataContext : IDisposable
    { 
        IPlayerRepository PlayerRepository { get; }

        IMessengerRepository MessengerRepository { get; }

        void Commit();

        void Rollback();
    }
}
