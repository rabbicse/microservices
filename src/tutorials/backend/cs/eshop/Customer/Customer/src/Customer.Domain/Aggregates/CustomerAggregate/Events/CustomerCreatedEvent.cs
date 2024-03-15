using Mehedi.Core.SharedKernel;

namespace Customer.Domain.Aggregates.CustomerAggregate.Events;

public class CustomerCreatedEvent(Guid id, string firstName, string lastName, DateTime dob): BaseDomainEvent
{
    public Guid Id { get; private init; } = id;
    public string FirstName { get; private init; } = firstName;
    public string LastName { get; private init; } = lastName;
    public DateTime Dob { get; private init; } = dob;
}
