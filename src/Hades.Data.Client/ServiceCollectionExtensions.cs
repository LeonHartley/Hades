using Microsoft.Extensions.DependencyInjection;

namespace Hades.Data.Client
{
    public static class ServiceCollectionExtensions
    {
        public static void UseDataClient(this IServiceCollection serviceCollection, DataClientOptions clientOptions)
        {
            serviceCollection.AddSingleton(clientOptions);
            serviceCollection.AddSingleton<IDataClientProvider, DataClientProvider>();
        }
    }
}