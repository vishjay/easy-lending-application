using CreditCheckService.Application.Interfaces;
using CreditCheckService.Infrastructure.External;
using CreditCheckService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CreditCheckService.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<CreditDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("Default")));

            services.AddScoped<ICreditRepository, CreditRepository>();
            services.AddScoped<ICreditApi, CreditApi>();

            return services;
        }
    }
}
