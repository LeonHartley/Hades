using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Models.Players.Messenger
{
    public class PlayerFriend
    {
        public int PlayerId { get; set; }

        public RelationshipStatus Relationship { get; set; }

        public virtual PlayerData Data { get; set; }
    }
}
