﻿using Customer.Application.UseCases.Customers.DTOs;
using FluentValidation;
using MediatR;
using Mehedi.Application.SharedKernel.Responses;
using Mehedi.Core.SharedKernel;

namespace Customer.Application.UseCases.Customers.Commands
{
    public class CreateCustomerCommandHandler(
        IValidator<CreateCustomerCommand> validator,
        ICustomerWriteOnlyRepository repository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateCustomerCommand, Result<CreatedCustomerResponse>>
    {
        private readonly ICustomerWriteOnlyRepository _repository = repository;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IValidator<CreateCustomerCommand> _validator = validator;

        public async Task<Result<CreatedCustomerResponse>> Handle(
            CreateCustomerCommand request,
            CancellationToken cancellationToken)
        {
            // Validating the request.
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                // Return the result with validation errors.
                return Result<CreatedCustomerResponse>.Invalid(validationResult.AsErrors());
            }

            // Instantiating the Email value object.
            //var email = Email.Create(request.Email).Value;

            // Checking if a customer with the email address already exists.
            //if (await _repository.ExistsByEmailAsync(email))
            //    return Result<CreatedCustomerResponse>.Error("The provided email address is already in use.");

            // Creating an instance of the customer entity.
            // When instantiated, the "CustomerCreatedEvent" will be created.
            //var customer = CustomerFactory.Create(
            //    request.FirstName,
            //    request.LastName,
            //    request.Gender,
            //    email,
            //    request.DateOfBirth);

            //// Adding the entity to the repository.
            //_repository.Add(customer);

            // Saving changes to the database and triggering events.
            await _unitOfWork.SaveChangesAsync();

            // Returning the ID and success message.
            return Result<CreatedCustomerResponse>.Success(
                new CreatedCustomerResponse(customer.Id), "Successfully registered!");
        }
    }
}
