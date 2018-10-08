using System.Collections.Generic;
using System.Threading.Tasks;
using Hades.Data.Model.Players.Inventory;

namespace Hades.Data.Repositories.Players
{
    public interface IInventoryRepository
    {
        Task<List<PlayerBadge>> GetBadges(long playerId);
    }
}