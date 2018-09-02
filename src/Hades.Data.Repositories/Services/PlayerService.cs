using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Cache;
using Hades.Data.Model.Players;
using Hades.Data.Repositories.Players;

namespace Hades.Data.Repositories.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly ICache<Player> _playerCache;

        public PlayerService(ICacheProvider cacheProvider, IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
            _playerCache = cacheProvider.GetCache(Caches.PlayerCache);
        }
        
        public async Task<Player> Authenticate(string ssoTicket)
        {
            var player = await _playerRepository.Authenticate(ssoTicket);

            if(player != null)
            {
                return new Player { Data = player };
            }

            return null;
        }
    }
}
