using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ordering.Application.UseCases.Orders.Commands;
using Ordering.Application.UseCases.Orders.DTOs;

namespace Ordering.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private IMediator _mediator;

        public OrderController(ILogger<OrderController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            return Ok("Hello");
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
