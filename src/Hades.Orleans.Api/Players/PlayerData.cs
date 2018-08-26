using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Orleans.Api.Players
{
    [Serializable]
    public class PlayerData
    {
        public long Id { get; set; }

        public string Name{ get; set; }

        public string Figure { get; set; }

        public string Motto { get; set; }

        public int Credits { get; set; }

        public int VipPoints { get; set; }

        public int ActivityPoints { get; set; }

        public int AchievementPoints { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastActivity { get; set; }

        public int? FavouriteGroup { get; set; }

        public int RankId { get; set; }
    }
}
