using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Orleans.Api.Players.Messenger
{
    public interface IMessengerFriend
    {
        int PlayerId { get; }

        Task SendMessage(string message);
    }
}
