using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
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

    [HttpGet("GetPost")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var res = await _mediator.Send(new GetByIdPostInformationRecord(id));
        if (res is not null)
        {
            return StatusCode(StatusCodes.Status200OK, res);
        }
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreatePostInformationDTO createPostInformationDTO)
    {
        // map object 
        // prepare data for CQRS commandHandler - Here is CreatePostInformationCommandHandler
        // The object that should be considered for mapping is CreatePostInformationRecord
        var mapObj = _mapper.Map<CreatePostInformationRecord>(createPostInformationDTO);
        var res = await _mediator.Send(mapObj);
        if (res is not null)
        {
            return StatusCode(StatusCodes.Status201Created, res);
        }
        return BadRequest();
    }
}