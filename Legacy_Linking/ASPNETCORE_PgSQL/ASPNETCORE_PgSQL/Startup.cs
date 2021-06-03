using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.repository.Implementations;
using demo.repository.Interfaces;
using Demo.db;
using Demo.service.Implementations;
using Demo.service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ASPNETCORE_PgSQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ToDoContext>(options =>
                       options.UseNpgsql(Configuration.GetConnectionString("ToDoDb")));
            services.AddControllers();

            services.AddTransient<ToDoSeeder>();
            services.AddScoped(typeof(IToDoRepository), typeof(ToDoRepository));
            services.AddScoped(typeof(IToDoService), typeof(ToDoService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<ToDoSeeder>();
                seeder.Seed().Wait();
            }
        }
    }
}
