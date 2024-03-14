using Mehedi.Core.SharedKernel;
using Ordering.Domain.Aggregates.OrderAggregate;

namespace Ordering.Domain.Events
{
    /// <summary>
    /// Event used when the grace period order is confirmed
    /// </summary>
    public class OrderStatusChangedToAwaitingValidationDomainEvent<T>(T orderId, IEnumerable<OrderItem> orderItems) : BaseEvent
    {
        public T OrderId { get; } = orderId;
        public IEnumerable<OrderItem> OrderItems { get; } = orderItems;
    }
}
