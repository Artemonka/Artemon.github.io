using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStore.Data;
using ServiceStore.Data.Interfaces;
using ServiceStore.Data.Mocks;
using ServiceStore.Data.Models;
using ServiceStore.Data.Repository;

namespace ServiceStore
{
    public class Startup
    {
        private IConfigurationRoot _confstring;

        public Startup(IHostingEnvironment configuration)
        {
            _confstring = new ConfigurationBuilder().SetBasePath(configuration.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllServices, ServiceRepository>();
            services.AddTransient<IAllPersonals, PersonalRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseCookiePolicy();
                app.UseStaticFiles();
                app.UseSession();
                app.UseMvcWithDefaultRoute();

                using (var scope = app.ApplicationServices.CreateScope())
                {
                    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                    DBObjects.Initial(content);
                }

            }
            else
            {
                app.UseExceptionHandler("/Store/Error");
                app.UseHsts();
            }

            

        
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Store}/{action=Services}/{id?}");
            });
        }
    }
}
