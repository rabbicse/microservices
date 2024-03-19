using Mehedi.Application.SharedKernel.Persistence;

namespace Customer.Application.UseCases.Customers.Repositories;

public interface ICustomerCommandRepository : ICommandRepository<Domain.Aggregates.CustomerAggregate.Customer, Guid>
{
}
