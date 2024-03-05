using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Ordering.Application.Common.Persistence;
using Ordering.Infrastructure.Persistence;

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


            services.AddScoped<Func<IWriteDbContext?>>((provider) => provider.GetService<ApplicationDbContext?>);

            //logger.LogInformation($"Infrastructure services registered");

            return services;
        }
    }
}
