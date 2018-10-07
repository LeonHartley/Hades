﻿using Hades.Common.Cache;
using Hades.Data.Exceptions;
using Hades.Data.Model.Players;
using Hades.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Exceptions.Errors;
using Hades.Data.Processors.Interfaces;
using Hades.Data.Services.Interfaces;

namespace Hades.Data.Processors
{
    public class PlayerDataProcessor : IPlayerDataProcessor
    {
        private readonly IPlayerDataService _playerDataService;

        public PlayerDataProcessor(IPlayerDataService playerDataService)
        {
            _playerDataService = playerDataService;
        }

        public async Task<PlayerData> GetPlayerData(long id)
        {
            return await _playerDataService.GetPlayerData(id);
        }
    }
}