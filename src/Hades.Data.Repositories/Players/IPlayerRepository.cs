using Hades.Data.Model.Players;
using System.Threading.Tasks;

namespace Hades.Data.Repositories.Players
{
    public interface IPlayerRepository : IRepository
    {
        Task<PlayerData> GetPlayerById(long id);

        Task Save(PlayerData playerData);
    }
}
