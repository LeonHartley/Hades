using Hades.Data.Model.Players;
using Hades.Data.MySql.Context;
using Hades.Data.Repositories.Players;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Hades.Data.MySql.Repositories
{
    public class PlayerRepository : RepositoryBase, IPlayerRepository
    {
        private const string PlayerDataSelectSql = @"
                SELECT p.Id, p.Name, a.Figure, a.Motto, a.Credits, a.VipPoints, a.ActivityPoints,
                       a.AchievementPoints, a.DateCreated, a.DateLastActivity, a.FavouriteGroup, a.RankId
                FROM players p LEFT JOIN player_avatars a ON a.Id = p.AvatarId";

        public PlayerRepository(MySqlDataContext context) : base(context)
        {
            
        }

        public async Task<PlayerData> GetPlayerById(long playerId)
        {
            return await Connection.QueryFirstOrDefaultAsync<PlayerData>($@"{PlayerDataSelectSql} WHERE p.Id = @playerId", new { playerId });
        }

        public async Task<List<PlayerData>> GetPlayersById(IEnumerable<long> ids)
        {
            return (await Connection.QueryAsync<PlayerData>(
                $@"{PlayerDataSelectSql} WHERE p.Id IN ({string.Join(",", ids)})")).ToList();
        }

        public Task Save(PlayerData playerData)
        {
            throw new NotImplementedException();
        }
    }
}
