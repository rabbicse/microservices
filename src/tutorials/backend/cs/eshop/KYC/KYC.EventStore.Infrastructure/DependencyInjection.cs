using KYC.EventStore.Infrastructure.Persistence;
using KYC.EventStore.Infrastructure.Repositories;
using Mehedi.Application.SharedKernel.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KYC.EventStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddEventStoreInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {
        string? connectionString = config.GetConnectionString("EventStoreSqlConnection");
        // For SQLServer Connection
        services.AddDbContext<EventStoreDbContext>(options =>
        {
            options.UseSqlServer(
                connectionString,
                sqlServerOptionsAction: sqlOptions =>
                {
                });
        });

        return services.AddScoped<EventStoreDbContext>()
            .AddScoped<IEventStoreRepository, EventStoreRepository>();
    }
}
