﻿using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache.Interfaces
{
    public interface IPlayerDataCache : IObjectCache<long, PlayerData>
    {
    }
}
