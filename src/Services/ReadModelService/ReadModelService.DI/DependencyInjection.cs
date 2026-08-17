using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReadModelService.Application.Interfaces;
using ReadModelService.Infrastructure.Persistence;

namespace ReadModelService.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<ReadModelDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("Default")));

            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<IDashboardReadRepository, DashboardReadRepository>();

            return services;
        }
    }
}
