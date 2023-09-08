using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;
using EcommereceWeb.Infrstraction.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



using Microsoft.Extensions.DependencyInjection;


namespace EcommereceWeb.Infrstraction.Extensions
{
    public static class AddPresistenceExtensision
    {

        public static IServiceCollection AddPresistence(this IServiceCollection service,IConfiguration configuration)
        {
            string conString = "Server=DESKTOP-VC0T8OV\\AQLAN;Database=WebEcommerce;Trusted_Connection = yes;";
            service.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(conString));
            //service.AddDbContext<ApplicationDbContext>(op =>op.UseSqlServer(configuration.GetConnectionString("SqlServerDB")));
           
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
          
            service.AddIdentity<User, IdentityRole>(bulder =>
            {
                bulder.User.RequireUniqueEmail = false;
                bulder.Password.RequireLowercase = false;
                bulder.Password.RequireDigit = false;
                bulder.Password.RequiredUniqueChars = 0;
                bulder.Password.RequireUppercase = false;
                bulder.Password.RequireNonAlphanumeric = false;
                bulder.Password.RequiredLength = 6;


            }).AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            return service;
           
            


        }
     
    }
}
