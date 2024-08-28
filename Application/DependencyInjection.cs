using Application.Services;
using Domain.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IServiceTransaction, ServiceTransaction>();

            return services;
        }
    }
}
