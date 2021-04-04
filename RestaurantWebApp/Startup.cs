using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantWebApp.Models.DAL;
using RestaurantWebApp.Services;

namespace RestaurantWebApp
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
            // MySQL Database Connection credentials
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];

            // Attempts to obtain DB Password from local system and concatenate to connectionString
            try
            {
                string dbPass = Environment.GetEnvironmentVariable("MYSQL_REMOTE_DB");
                connectionString += dbPass + ";";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            // Adds DbContext to services via dependency injection
            services.AddDbContext<RestaurantDbContext>(options => options.UseMySql(connectionString));
            
            // Gives controller scoped access to DAOs and Services via dependency injection
            services.AddScoped<IMenuItemDao, MenuItemDao>();
            services.AddScoped<IMenuItemService, MenuItemService>();
            
            services.AddScoped<IOrderDao, OrderDao>();
            services.AddScoped<IOrderService, OrderService>();
            
            services.AddScoped<IOrderItemDao, OrderItemDao>();
            services.AddScoped<IOrderItemService, OrderItemService>();
            
            services.AddScoped<IDeliveryOrderDao, DeliveryOrderDao>();
            services.AddScoped<IDeliveryOrderService, DeliveryOrderService>();
            
            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}