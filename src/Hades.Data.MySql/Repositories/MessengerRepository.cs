using Hades.Data.MySql.Context;
using Hades.Data.Repositories.Players;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Hades.Data.Model.Players.Messenger;

namespace Hades.Data.MySql.Repositories
{
    public class MessengerRepository : RepositoryBase, IMessengerRepository
    {
        public MessengerRepository(MySqlDataContext context) : base(context)
        {
        }

        public async Task<List<PlayerFriend>> GetFriendships(long playerId)
        {
            return (await Connection.QueryAsync<PlayerFriend>(@"
                SELECT FriendId AS PlayerId, Relationship 
                FROM player_friends 
                WHERE PlayerId = @playerId;",
                new {playerId})).AsList();
        }
    }
}
