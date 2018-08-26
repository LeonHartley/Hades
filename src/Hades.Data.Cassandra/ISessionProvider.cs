using Cassandra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Repositories
{
    public interface ISessionProvider
    {
        ISession GetSession();
    }
}
