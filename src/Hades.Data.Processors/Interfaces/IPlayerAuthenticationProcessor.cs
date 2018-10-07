using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Processors.Interfaces
{
    public interface IPlayerAuthenticationProcessor
    {
        Task<Player> GetPlayer(string authenticationToken);
    }
}
