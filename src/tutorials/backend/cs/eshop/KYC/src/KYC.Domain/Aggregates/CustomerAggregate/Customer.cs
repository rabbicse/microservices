﻿using KYC.Domain.Aggregates.CustomerAggregate.Events;
using Mehedi.Core.SharedKernel;

namespace KYC.Domain.Aggregates.CustomerAggregate;

public class Customer(string firstName, string lastName, DateTime dob) : BaseEntity, IAggregateRoot
{
    #region Properties
    /// <summary>
    /// Gets the first name of the customer.
    /// </summary>
    public string FirstName { get; } = firstName;

    /// <summary>
    /// Gets the last name of the customer.
    /// </summary>
    public string LastName { get; } = lastName;
    /// <summary>
    /// Gets the date of birth of the customer.
    /// </summary>
    public DateTime Dob { get; } = dob;
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
