using Hades.Data.Model.Players;
using System.Threading.Tasks;

namespace Hades.Data.Repositories.Players
{
    public interface IPlayerRepository : IRepository
    {
        Task<PlayerData> GetPlayerById(int id);

        Task<PlayerData> Authenticate(string ssoTicket);

        Task Save(PlayerData playerData);
    }
}
