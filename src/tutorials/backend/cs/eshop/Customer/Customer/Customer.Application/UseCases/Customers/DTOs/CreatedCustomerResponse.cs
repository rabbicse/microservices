using Mehedi.Application.SharedKernel.Interfaces;

namespace Customer.Application.UseCases.Customers.DTOs;


public class CreatedCustomerResponse(Guid id) : IResponse
{
    public Guid Id { get; } = id;
}

