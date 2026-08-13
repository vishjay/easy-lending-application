using BorrowingPowerService.Application.Interfaces;
using BorrowingPowerService.Domain.Services;
using BorrowingPowerService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BorrowingPowerService.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<BorrowingDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("Default")));

            services.AddScoped<IBorrowingRepository, BorrowingRepository>();
            services.AddScoped<BorrowingCalculator>();

            return services;
        }
    }
}
