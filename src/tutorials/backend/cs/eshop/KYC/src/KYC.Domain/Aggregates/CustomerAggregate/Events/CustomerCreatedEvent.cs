namespace KYC.Domain.Aggregates.CustomerAggregate.Events;

public class CustomerCreatedDomainEvent(Guid id, string firstName, string lastName, DateTime dob): CustomerBaseDomainEvent(id, firstName, lastName, dob)
{
}
