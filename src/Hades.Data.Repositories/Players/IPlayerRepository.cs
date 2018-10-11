using System.Collections.Generic;
using Hades.Data.Model.Players;
using System.Threading.Tasks;

namespace Hades.Data.Repositories.Players
{
    public interface IPlayerRepository : IRepository
    {
        Task<PlayerData> GetPlayerById(long id);

        Task<List<PlayerData>> GetPlayersById(IEnumerable<long> ids);

        Task Save(PlayerData playerData);
    }
}
