using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mantenimiento.DTO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVotacionAutomatizada.Models;
using WebApiPaises.Models;

namespace SistemaVotacionAutomatizada
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
          .AddEntityFrameworkStores<ApplicationDbContext>()
          .AddDefaultTokenProviders();
            services.AddDistributedMemoryCache();
            services.AddSession(option => { option.IdleTimeout = TimeSpan.FromHours(2); });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            LoginDTO pruebaUser = new LoginDTO { UserName = "Kevin", Password = "Kevin" };
            if (!context.AspNetUser.Any())
            {
                context.Paises.AddRange(new Pais()
                {
                    Nombre = "Republica Dominicana",
                    Provincias = new List<Provincia>() {
                                    new Provincia() { Nombre = "La Romana"}
                                }
                },
                    new Pais()
                    {
                        Nombre = "Chile",
                        Provincias = new List<Provincia>() {
                                    new Provincia() { Nombre = "Monte Rey"},
                                    new Provincia(){Nombre = "Queretaro" }
                    }
                    },
                    new Pais()
                    {
                        Nombre = "Estado Unidos",
                        Provincias = new List<Provincia>() {
                                    new Provincia() { Nombre = "Florida"},
                                    new Provincia() { Nombre = "Texas" }
                        }
                    });
                context.SaveChanges();
            }
        }
    }
}
