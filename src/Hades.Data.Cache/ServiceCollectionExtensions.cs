using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    public static class ServiceCollectionExtensions
    {
        public static void UseDataCache(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton
        }
    }
}
