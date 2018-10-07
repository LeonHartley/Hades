using Microsoft.Extensions.DependencyInjection;
using Hades.Data.MySql.Context;
using Hades.Data.Repositories;

namespace Hades.Data.MySql
{
    public static class ServiceCollectionExtensions
    {
        public static void UseMySqlData(this IServiceCollection serviceCollection, MySqlDataOptions options)
        {
            serviceCollection.AddSingleton(options);
            serviceCollection.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>();
            serviceCollection.AddSingleton<IConnectionProvider, MySqlConnectionProvider>();
            serviceCollection.AddSingleton<IDataContextProvider, MySqlDataContextProvider>();
        }
    }
}