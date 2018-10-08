using Hades.Data.MySql.Context;
using Hades.Data.Repositories.Players;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Hades.Data.Model.Players.Inventory;

namespace Hades.Data.MySql.Repositories
{
    public class InventoryRepository : RepositoryBase, IInventoryRepository
    {
        public InventoryRepository(MySqlDataContext context) : base(context)
        {
        }

        public async Task<List<PlayerBadge>> GetBadges(long playerId)
        {
            return (await Connection.QueryAsync<PlayerBadge>(@"
                SELECT Code, Slot 
                FROM player_badges 
                WHERE PlayerId = @playerId;",
                new {playerId})).AsList();
        }
    }
}