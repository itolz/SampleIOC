using Microsoft.Extensions.DependencyInjection;
using SampleIOC.Domain.Interfaces;
using SampleIOC.Services;

namespace SampleIOC.Dependencies
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IServiceClub, ServiceClub>();
        }
    }
}