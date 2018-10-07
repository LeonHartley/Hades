using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Hades.Data.Processors.Interfaces;
using Hades.Data.Processors.Players;

namespace Hades.Data.Processors
{
    public static class ServiceCollectionExtensions
    {
        public static void UseDataProcessors(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IPlayerAuthenticationProcessor, PlayerAuthenticationProcessor>();
            serviceCollection.AddSingleton<IPlayerDataProcessor, PlayerDataProcessor>();
        }
    }
}
