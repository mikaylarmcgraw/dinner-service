namespace DinnerMenu
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using Core;
    using Infrastructure;
    using Microsoft.Extensions.Logging;

    public static class RegistrationExtensions
    {
        public static IServiceCollection AddDinnerService(this IServiceCollection services)
        {
            services.AddTransient<IDinnerService, DinnerService>();
            services.AddScoped<IDinnerRepository, DinnerMenuRepository>();
            services.AddSingleton(new LoggerFactory()
                

                );

            return services;
        }
    }
}
