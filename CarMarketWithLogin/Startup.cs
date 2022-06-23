using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarMarketWithLogin.Data;
using CarMarketWithLogin.Data.Repository;
using CarMarketWithLogin.Interfaces;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarMarketWithLogin
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
            
            services.AddMvc();
            services.AddControllersWithViews();
            
            string connectionString = "server=localhost;user=root;password=123456789;database=CarMarketWithLogin";
            
            services.AddDbContext<ApplicationDbContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors());
            
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<IBodyType, BodyTypeRepository>();
            services.AddTransient<ICapacity, CapacityRepositiry>();
            services.AddTransient<IDriveUnit, DriveUnitRepository>();
            services.AddTransient<IEngineType, EngineTypeRepository>();
            services.AddTransient<IImgs, ImgRepository>();
            services.AddTransient<ITransmission, TransmissionRepository>();

           // services.AddIdentity<User, IdentityRole>(options =>
           //     {
           //         options.SignIn.RequireConfirmedAccount = true;
           //         options.Password.RequireNonAlphanumeric = false;
           //     })
           //     .AddEntityFrameworkStores<ApplicationDbContext>();
           //
            
           
            services.AddDefaultIdentity<User>(options =>
                {
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequiredUniqueChars = 0;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = true;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>();
           
            
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();
            
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            
            using (var scope = app.ApplicationServices.CreateScope())
            { 
                ApplicationDbContext content = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                DBObjects.Initial(content);
            }
        }
    }
}