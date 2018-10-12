using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Model;
using Hades.Data.Model.Players;

namespace Hades.Data.Processors.Interfaces
{
    public interface IPlayerDataProcessor
    {
        Task<Player> GetPlayer(long id);
        
        Task<PlayerData> GetPlayerData(long id);
    }
}
