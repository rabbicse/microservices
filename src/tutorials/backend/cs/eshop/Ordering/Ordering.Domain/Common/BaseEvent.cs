namespace Ordering.Domain.Common
{
    /// <summary>
    /// Represents a base event.
    /// </summary>
    public abstract class BaseEvent : IDomainEvent
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
}
