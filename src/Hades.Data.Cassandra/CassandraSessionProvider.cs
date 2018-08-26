using System;
using System.Collections.Generic;
using System.Text;
using Cassandra;

namespace Hades.Data.Repositories
{
    public class CassandraSessionProvider : ISessionProvider
    {
        private readonly ISession _session;

        public CassandraSessionProvider(ISession session)
        {
            _session = session;
        }

        public ISession GetSession()
        {
            return _session;
        }
    }
}
