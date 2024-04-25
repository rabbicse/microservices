using Newtonsoft.Json;

namespace Demo;

public abstract class BaseDomainEvent
{
    /// <summary>
    /// Gets the type of the message.
    /// </summary>
    public string? MessageType { get; protected init; }

    /// <summary>
    /// Gets the aggregate ID.
    /// </summary>
    public Guid AggregateId { get; protected init; }

    /// <summary>
    /// Gets the date and time when the event occurred.
    /// </summary>
    public DateTime OccurredOn { get; private init; } = DateTime.Now;
}

public abstract class CustomerBaseDomainEvent(Guid id,
                                string firstName,
                                string lastName,
                                DateTime dob) : BaseDomainEvent
{
    public Guid Id { get; private init; } = id;
    public string FirstName { get; private init; } = firstName;
    public string LastName { get; private init; } = lastName;
    public DateTime Dob { get; private init; } = dob;
}

public class CustomerCreatedEvent(Guid id, string firstName, string lastName, DateTime dob) : CustomerBaseDomainEvent(id, firstName, lastName, dob)
{
}
