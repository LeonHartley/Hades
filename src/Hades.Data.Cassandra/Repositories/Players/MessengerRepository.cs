using Hades.Data.Repositories;
using Hades.Data.Repositories.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cassandra.Repositories.Players
{
    public class MessengerRepository : CassandraRepository, IMessengerRepository
    {
        public MessengerRepository(int instanceId, ISessionProvider sessionProvider) : base(instanceId, sessionProvider)
        {
        }
    }
}
