using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Client.Players
{
    public interface IPlayerClient
    { 
        Task<Player> Authenticate(string ssoTicket);
    }
}
