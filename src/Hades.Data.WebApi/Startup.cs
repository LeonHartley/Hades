using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hades.Common.Cache;
using Hades.Data.Cache;
using Hades.Data.MySql;
using Hades.Data.Processors;
using Hades.Data.Repositories;
using Hades.Data.Services;
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
                ConnectionString = "Server=localhost;Database=hades_game;Uid=dbuser;Pwd=123123;"
            });

            services.UseDataCache();
            services.UseDataServices();
            services.UseDataProcessors();
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
