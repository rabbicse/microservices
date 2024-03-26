using KYC.Domain.Aggregates.CustomerAggregate;
using Mehedi.Application.SharedKernel.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KYC.Write.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IWriteDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Customer> Orders => Set<Customer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

