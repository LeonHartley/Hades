using Hades.Data.Cassandra.Repositories.Players;
using Hades.Data.Repositories;
using Hades.Data.Repositories.Players;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cassandra
{
    public static class ServiceCollectionExtensions
    {
        public static void UseCassandraData(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ISessionProvider, CassandraSessionProvider>();
            serviceCollection.AddSingleton<IPlayerRepository, PlayerRepository>();
            serviceCollection.AddSingleton<IMessengerRepository, MessengerRepository>();
        }
    }
}
