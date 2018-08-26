using Hades.Data.Models.Players.Inventory;
using Hades.Data.Models.Players.Messenger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Models.Players
{
    public class Player
    {
        public long Id { get; }

        public PlayerData Data { get; }

        public List<PlayerFriend> Friends { get; }

        public List<PlayerBadge> Badges { get; }
    }
}
