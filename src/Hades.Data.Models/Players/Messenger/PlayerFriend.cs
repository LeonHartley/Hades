using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Model.Players.Messenger
{
    public class PlayerFriend
    {
        public int PlayerId { get; set; }

        public RelationshipStatus Relationship { get; set; }
    }
}
