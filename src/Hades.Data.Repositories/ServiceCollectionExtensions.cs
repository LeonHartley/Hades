using Hades.Data.Repositories.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void UseRepositoryServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IPlayerService, PlayerService>();
        }
    }
}
