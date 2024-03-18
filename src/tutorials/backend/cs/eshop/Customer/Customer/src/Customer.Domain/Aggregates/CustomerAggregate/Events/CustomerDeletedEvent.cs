namespace Customer.Domain.Aggregates.CustomerAggregate.Events;

public class CustomerDeletedEvent(Guid id, string firstName, string lastName, DateTime dob) : CustomerBaseDomainEvent(id, firstName, lastName, dob)
{
}
