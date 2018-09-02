using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    public static class ServiceCollectionExtensions
    {
        public static void UseRedisCache(this IServiceCollection serviceCollection, RedisCacheOptions redisCacheOptions)
        {
            serviceCollection.AddSingleton(redisCacheOptions);

            serviceCollection.AddSingleton<IRedisConnectionProvider, RedisConnectionProvider>();
            serviceCollection.AddSingleton<IRedisDatabaseProvider, RedisDatabaseProvider>();
            serviceCollection.AddSingleton<ICacheProvider, RedisCacheProvider>();
        }
    }
}
