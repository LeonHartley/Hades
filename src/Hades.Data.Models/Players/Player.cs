using Hades.Common.Cache;
using Hades.Data.Model.Players.Inventory;
using Hades.Data.Model.Players.Messenger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Model.Players
{
    public class Player : ICacheItem
    {
        public long Id { get; set;  }

        public PlayerData Data { get; set;  }

        public List<PlayerFriend> Friends { get; set; }

        public List<PlayerBadge> Badges { get; set;  }
    }
}
