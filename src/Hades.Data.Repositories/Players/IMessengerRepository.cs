using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Model.Players.Messenger;

namespace Hades.Data.Repositories.Players
{
    public interface IMessengerRepository
    {
        Task<List<PlayerFriend>> GetFriendships(long playerId);
    }
}
