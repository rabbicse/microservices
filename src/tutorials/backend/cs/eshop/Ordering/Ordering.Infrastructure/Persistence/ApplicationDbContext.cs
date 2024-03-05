using Microsoft.EntityFrameworkCore;
using Ordering.Application.Common.Persistence;
using Ordering.Domain.Aggregates.OrderAggregate;
using System.Reflection;

namespace Ordering.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IWriteDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders => Set<Order>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
