using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GestaoTarefasIPG.Models;
using Microsoft.Extensions.Logging;
using GestaoTarefasIPG.Data;
using Microsoft.AspNetCore.Identity;

namespace GestaoTarefasIPG
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
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();

            services.AddControllersWithViews();

            services.AddRazorPages();

            services.AddDbContext<ProfessorDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ProfessorDbContext")));

            services.AddDbContext<FuncionarioDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("FuncionarioDbContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            ILoggerFactory loggerFactory,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {

            SeedData.CreateRolesAsync(roleManager).Wait();

            if (env.IsDevelopment())
            {
                using (var serviceScope = app.ApplicationServices.CreateScope())
                {
                    var db = serviceScope.ServiceProvider.GetService<ProfessorDbContext>();
                    var dbF = serviceScope.ServiceProvider.GetService<FuncionarioDbContext>();
                    SeedData.Populate(db);
                    SeedData.PopulateFuncionario(dbF);
                    SeedData.PopulateUsersAsync(userManager).Wait();
                }
            }

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
        }
    }
}

