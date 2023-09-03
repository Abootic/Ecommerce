

using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using  Microsoft.AspNetCore.Identity.EntityFrameworkCore;


using Microsoft.Extensions.DependencyInjection;


namespace EcommereceWeb.Infrstraction.Extensions
{
    public static class AddPresistenceExtensision
    {

        public static IServiceCollection AddPresistence(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(op =>

                op.UseSqlServer(configuration.GetConnectionString("SqlServerDB")));
            
            service.AddIdentity<User, IdentityRole>(bulder =>
            {
                bulder.User.RequireUniqueEmail = true;
                bulder.Password.RequireLowercase = true;
                bulder.Password.RequireDigit = false;
                bulder.Password.RequiredUniqueChars = 0;
                bulder.Password.RequireUppercase = true;
                bulder.Password.RequireNonAlphanumeric = false;
                bulder.Password.RequiredLength = 6;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>();

            /*service.AddIdentityCore<ApplicationUser>(bulder =>
            {
                bulder.User.RequireUniqueEmail = true;
                bulder.Password.RequireLowercase = true;
                bulder.Password.RequireDigit = false;
                bulder.Password.RequiredUniqueChars = 0;
                bulder.Password.RequireUppercase = true;
                bulder.Password.RequireNonAlphanumeric = false;
                bulder.Password.RequiredLength = 6;
            }).AddSignInManager().AddRoles<IdentityRole>().AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
*/


            return service;
            


        }
     
    }
}
