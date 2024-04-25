namespace KYC.Domain.Aggregates.CustomerAggregate.Events;

public class CustomerCreatedEvent(Guid id, string firstName, string lastName, DateTime dob): CustomerBaseDomainEvent(id, firstName, lastName, dob)
{
}
