using Hades.Data.Model.Players;
using Hades.Data.Repositories;
using Hades.Data.Repositories.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Cassandra.Repositories.Players
{
    public class PlayerRepository : CassandraRepository, IPlayerRepository
    {
        public PlayerRepository(int instanceId, ISessionProvider sessionProvider) : base(instanceId, sessionProvider)
        {
        }

        public Task<PlayerData> Authenticate(string ssoTicket)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerData> GetPlayerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save(PlayerData playerData)
        {
            throw new NotImplementedException();
        }
    }
}
