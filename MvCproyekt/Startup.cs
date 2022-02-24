using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvCproyekt.BLL.Services;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.DAL.Core;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.DAL.Repositories;
using MvCproyekt.DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt
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
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options =>
            {

                options.UseNpgsql(Configuration.GetConnectionString("Db"));


            });
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ISectorRepository, SectorRepository>();
            services.AddScoped<ISectorService, SectorService>();
            services.AddAutoMapper(typeof(Automapper));
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Sector}/{action=Index}/{id?}");
            });
        }
    }
}
