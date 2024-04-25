using Mehedi.Core.SharedKernel;
using Newtonsoft.Json;

namespace KYC.Domain.Aggregates.CustomerAggregate.Events;

public class CustomerBaseDomainEvent(Guid id,
                                string firstName,
                                string lastName,
                                DateTime dob) : BaseDomainEvent
{
    [JsonProperty]
    public Guid Id { get; private init; } = id;
    public string FirstName { get; private init; } = firstName;
    public string LastName { get; private init; } = lastName;
    [JsonProperty]
    public DateTime Dob { get; private init; } = dob;
}
