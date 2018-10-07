using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hades.Data.Cache;
using Hades.Data.Cassandra;
using Hades.Data.MySql;
using Hades.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hades.Data.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.UseRedisCache(new RedisCacheOptions
            {
                Host = "127.0.0.1",
                Port = 6379
            });

            services.UseMySqlData(new MySqlDataOptions
            {
                ConnectionString = "hi"
            });
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
