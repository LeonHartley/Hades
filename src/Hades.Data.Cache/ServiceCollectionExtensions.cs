using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Hades.Data.Cache.Interfaces;
using Hades.Data.Cache.Providers;

namespace Hades.Data.Cache
{
    public static class ServiceCollectionExtensions
    {
        public static void UseDataCache(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<PlayerTokenStoreProvider, PlayerTokenStoreProvider>();
            serviceCollection.AddSingleton<IPlayerCacheProvider, PlayerCacheProvider>();
            serviceCollection.AddSingleton<IPlayerDataCacheProvider, PlayerDataCacheProvider>();
        }
    }
}
