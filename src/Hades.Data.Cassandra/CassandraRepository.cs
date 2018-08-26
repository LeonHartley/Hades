using Cassandra;
using Hades.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cassandra
{
    public class CassandraRepository : Repository
    {
        private readonly ISessionProvider _sessionProvider;

        public CassandraRepository(int instanceId, ISessionProvider sessionProvider) : base(instanceId)
        {
            _sessionProvider = sessionProvider;
        }

        protected ISession Session => _sessionProvider.GetSession();
    }
}
