using Microsoft.Extensions.DependencyInjection;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Cache.Players;

namespace Hades.Data.Cache
{
    public static class ServiceCollectionExtensions
    {
        public static void UseDataCache(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IPlayerTokenStore, PlayerTokenStore>();
            serviceCollection.AddSingleton<IPlayerDataCache, PlayerDataCache>();
            serviceCollection.AddSingleton<IPlayerCache, PlayerCache>();
        }
    }
}
