using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Domain.Common;

namespace Ordering.Domain.Events
{

    /// <summary>
    /// Event used when an order is created
    /// </summary>
    public record class OrderStartedDomainEvent(
        Order Order,
        string UserId,
        string UserName,
        int CardTypeId,
        string CardNumber,
        string CardSecurityNumber,
        string CardHolderName,
        DateTime CardExpiration) : IDomainEvent;
}
