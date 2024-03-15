using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Application.Common.Persistence;
using Ordering.Application.UseCases.Orders.Repositories;
using Ordering.Domain.Common;
using Ordering.Infrastructure.Persistence;
using Ordering.Infrastructure.Repositories;
using Ordering.Write.Infrastructure.Common;
using Ordering.Write.Infrastructure.Repositories;

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {
            string? connectionString = config.GetConnectionString("DbConnection");
            // For SQLServer Connection
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(
                    connectionString,
                    sqlServerOptionsAction: sqlOptions =>
                    {
                    });
            });


            services.AddScoped<IWriteDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();

            //logger.LogInformation($"Infrastructure services registered");

            return services;
        }
    }
}
