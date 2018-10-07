using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Model.Players;

namespace Hades.Data.Services.Interfaces
{
    public interface IPlayerDataService
    {
        Task<Player> GetPlayer(long id);
    }
}
