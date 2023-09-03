
using Microsoft.Extensions.DependencyInjection;
using EcommereceWeb.Application.Interfaces.Common;


namespace EcommereceWeb.Application.Extensions
{
    public static class ApplicationExtensions
    {
      public  static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
          
            return services;
        }
    }
}
