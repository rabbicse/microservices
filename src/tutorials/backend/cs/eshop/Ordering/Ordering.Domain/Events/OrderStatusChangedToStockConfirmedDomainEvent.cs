using Mehedi.Core.SharedKernel;

namespace Ordering.Domain.Events
{
    /// <summary>
    /// Event used when the order stock items are confirmed
    /// </summary>
    public class OrderStatusChangedToStockConfirmedDomainEvent<T>(T orderId) : BaseEvent
    {
        public T OrderId { get; } = orderId;
    }
}
