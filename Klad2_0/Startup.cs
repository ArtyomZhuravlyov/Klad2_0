using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Klad.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Klad
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

            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                //options.Cookie.Name = ".MyApp.Session";
                //options.Cookie.Expiration = TimeSpan.FromHours(6);
                //   options.IdleTimeout = TimeSpan.FromMinutes(59);
                options.IdleTimeout = TimeSpan.FromHours(6);
                options.Cookie.IsEssential = true;
                
            });

            services.Configure<FormOptions>(options =>
            {
                options.ValueCountLimit = int.MaxValue;
               
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
            });

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ProductContext>(options => options.UseSqlServer(connection));

            // установка конфигурации подключения
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.SlidingExpiration = true;
                    //options.ExpireTimeSpan = TimeSpan.FromMinutes(59);
                    options.ExpireTimeSpan = TimeSpan.FromHours(6);
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                    //куки - файлы действительны как минимум в течение 59 минутoptions.ExpireTimeSpan = TimeSpan.FromMinutes(59);
                    //, но могут быть продлены, options.SlidingExpiration = true; если страница обновляется или перемещается.
                });
            //services.AddScoped<IRepository, MemoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStaticFiles();
           
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    "Default", // Route name
                //    new { controller = "Home", action = "Index" } // Parameter defaults
                //    );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Main}/{id?}");

                //routes.MapRoute(null,
                //                "",
                //                new
                //                {
                //                    controller = "Home",
                //                    action = "Index",
                //                    category = (string)null,
                //                    page = 1
                //                }
                //            );

                //routes.MapRoute(
                //    name: null,
                //    url
                //    defaults: new { controller = "Home", action = "Index", category = (string)null },
                //    constraints: new { page = @"\d+" }
                //);

                //routes.MapRoute(null,
                //"{category}",
                //new { controller = "Home", action = "Index", page = 1 });

                routes.MapRoute(null,
                "{category}",
                new { controller = "Home", action = "Index" });


                //routes.MapRoute(null,
                //    "{category}/Page{page}",
                //    new { controller = "Home", action = "Index" },
                //    new { page = @"\d+" }
                //);

                routes.MapRoute(null,
               "{category}/{page}",
               new { controller = "Home", action = "Index" }
               //,
               //new { page = @"\d+" }
               );

                routes.MapRoute(null,
               "{IndexSearch}/{search}/{page}",
               new { controller = "Home", action = "IndexSearch" }
               //,
               //new { page = @"\d+" }
               );

                routes.MapRoute(null,
              "{productId}",
              new { controller = "Admin", action = "Edit" }
              //,
              //new { page = @"\d+" }
              );

                // routes.MapRoute(null,
                //"{AddToCart}",
                //new { controller = "Cart", action = "AddToCart" }
                //);

                //routes.MapRoute(null,
                // "{category}/{page}/{product}",
                // new { controller = "Home", action = "ViewProduct" },
                // new { page = @"\d+" }
                // );

                //   routes.MapRoute(null,
                //"{category}/{page}/{product}",
                //new { controller = "Home", action = "ViewProduct" },
                //new { page = @"\d+" },
                //new { page = @"\d+" }
                //);

            });
        }
    }
}
