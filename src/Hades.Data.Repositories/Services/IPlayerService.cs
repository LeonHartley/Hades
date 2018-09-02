using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Repositories.Services
{
    public interface IPlayerService
    {
        Task<Player> Authenticate(string ssoTicket);
    }
}
