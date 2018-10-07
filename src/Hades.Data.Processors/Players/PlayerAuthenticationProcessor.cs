using Hades.Data.Cache.Interfaces;
using Hades.Data.Model.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Processors.Players
{
    class PlayerAuthenticationProcessor
    {
        private readonly IPlayerCache _playerCache;

        public PlayerAuthenticationProcessor(IPlayerCache playerCache)
        {
            _playerCache = playerCache;
        }

        public async Task<Player> GetPlayer(long id)
        {
            return await _playerCache.Get(id, (playerId) =>
            {
                return null;
            });
        }
    }
}
