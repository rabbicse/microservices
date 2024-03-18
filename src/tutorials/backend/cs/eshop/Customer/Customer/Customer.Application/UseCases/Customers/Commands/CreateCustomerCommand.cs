﻿using Customer.Application.UseCases.Customers.DTOs;
using MediatR;
using Mehedi.Application.SharedKernel.Responses;
using System.ComponentModel.DataAnnotations;

namespace Customer.Application.UseCases.Customers.Commands;

public class CreateCustomerCommand : IRequest<Result<CreatedCustomerResponse>>
{
    [Required]
    [MaxLength(100)]
    [DataType(DataType.Text)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    [DataType(DataType.Text)]
    public string LastName { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }
}
