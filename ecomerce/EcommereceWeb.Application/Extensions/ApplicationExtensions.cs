﻿
using Microsoft.Extensions.DependencyInjection;



namespace EcommereceWeb.Application.Extensions
{
    public static class ApplicationExtensions
    {
      public  static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.Load("EcommereceWeb.Application")); 
          //  services.AddAutoMapper(ex => { ex.AddExpressionMapping(); }, AppDomain.CurrentDomain.Load("EcommereceWeb.Application"));

            return services;
        }
    }
}