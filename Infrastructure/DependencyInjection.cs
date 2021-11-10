using mekkl.Application.Common.Interfaces.Services;
using mekkl.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace mekkl.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTimeOffsetService, DateTimeOffsetService>();

            return services;
        }
    }
}