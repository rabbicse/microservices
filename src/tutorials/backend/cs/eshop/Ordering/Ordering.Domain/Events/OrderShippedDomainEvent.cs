using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Domain.Common;

namespace Ordering.Domain.Events
{
    public class OrderShippedDomainEvent : IDomainEvent
    {
        public Order Order { get; }

        public OrderShippedDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
