using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Hades.Common.Cache.Redis;

namespace Hades.Common.Cache
{
    public static class ServiceCollectionExtensions
    {
        public static void UseRedisCache(this IServiceCollection serviceCollection, RedisCacheOptions redisCacheOptions)
        {
            serviceCollection.AddSingleton(redisCacheOptions);

            serviceCollection.AddSingleton<IRedisConnectionProvider, RedisConnectionProvider>();
            serviceCollection.AddSingleton<IRedisDatabaseProvider, RedisDatabaseProvider>();
            serviceCollection.AddSingleton<ICacheProvider, RedisCacheProvider>();
            serviceCollection.AddSingleton<ICacheMapProvider, RedisCacheMapProvider>();
        }
    }
}
