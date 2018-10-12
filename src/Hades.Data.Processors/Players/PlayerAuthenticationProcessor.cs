using System;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Exceptions;
using Hades.Data.Exceptions.Errors;
using Hades.Data.Model.Players;
using Hades.Data.Processors.Interfaces;
using Hades.Data.Services.Interfaces;
using System.Threading.Tasks;

namespace Hades.Data.Processors.Players
{
    public class PlayerAuthenticationProcessor : IPlayerAuthenticationProcessor
    {
        private readonly IPlayerTokenStore _playerTokenStore;
        private readonly IPlayerDataService _playerDataService;

        public PlayerAuthenticationProcessor(IPlayerTokenStore playerTokenStore, IPlayerDataService playerDataService)
        {
            _playerTokenStore = playerTokenStore;
            _playerDataService = playerDataService;
        }

        public async Task<Player> GetPlayer(string authenticationToken) 
        {
            var playerId = await _playerTokenStore.Get(authenticationToken);

            if (!playerId.HasValue)
            {
                throw new PlayerAuthenticationException(PlayerAuthenticationError.InvalidTicket);
            }

            await _playerTokenStore.Remove(authenticationToken);
            return await _playerDataService.GetPlayer(playerId.Result);
        }
    }
}
