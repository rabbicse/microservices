using KYC.Domain.Aggregates.CustomerAggregate.Events;
using Mehedi.Core.SharedKernel;

namespace KYC.Domain.Aggregates.CustomerAggregate;

public class Customer : BaseEntity, IAggregateRoot
{
    public Customer(string firstName, string lastName, DateTime dob) 
    {
        FirstName = firstName;
        LastName = lastName;
        Dob = dob;
    }
    public Customer() { }

    #region Properties
    /// <summary>
    /// Gets the first name of the customer.
    /// </summary>
    public string FirstName { get; private set; }

    /// <summary>
    /// Gets the last name of the customer.
    /// </summary>
    public string LastName { get; private set; }
    /// <summary>
    /// Gets the date of birth of the customer.
    /// </summary>
    public DateTime Dob { get; private set; }
    #endregion

    #region Domain Event(s)
    /// <summary>
    /// Creates the new customer.
    /// </summary>
    public void Create()
    {
        // TODO: other business
        AddDomainEvent(new CustomerCreatedEvent(Id, FirstName, LastName, Dob));
    }
    /// <summary>
    /// Deletes the customer.
    /// </summary>
    public void Delete()
    {
        // TODO: Other business
        //AddDomainEvent(new CustomerDeletedEvent(Id, FirstName, LastName, Gender, Email.Address, DateOfBirth));
    }
    #endregion
}
