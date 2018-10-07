using Hades.Data.Services.Interfaces;
using Hades.Data.Services.Players;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void UseDataServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IPlayerDataService, PlayerDataService>();
        }
    }
}
