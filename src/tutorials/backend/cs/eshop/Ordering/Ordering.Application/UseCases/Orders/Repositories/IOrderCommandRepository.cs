using Ordering.Application.Common.Persistence;
using Ordering.Domain.Aggregates.OrderAggregate;

namespace Ordering.Application.UseCases.Orders.Repositories
{

    //This is just the RepositoryContracts or Interface defined at the Domain Layer
    //as requisite for the Order Aggregate

    public interface IOrderCommandRepository : ICommandRepository<Order>
    {
    }
}
