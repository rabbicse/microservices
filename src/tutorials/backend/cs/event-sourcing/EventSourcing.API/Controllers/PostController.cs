using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public PostController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var res = await _mediator.Send(new GetAllPostInformationRecord());
        if (res.Any())
        {
            return StatusCode(StatusCodes.Status200OK, res);
        }
        return NoContent();
    }
}