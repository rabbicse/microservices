// As shown in the above code, this class hanlde by CreatePostInformationRecord object and show PostInformationResponseDTO as a result
using AutoMapper;
using MediatR;

public class CreatePostInformationCommandHandler : IRequestHandler<CreatePostInformationRecord, PostInformationResponseDTO>
{
    private readonly IPostInformationCommandService _postInformationCommandService;
    private readonly IMapper _mapper;

    public CreatePostInformationCommandHandler(IMapper mapper, IPostInformationCommandService postInformationCommandService)
    {
        _postInformationCommandService = postInformationCommandService;
        _mapper = mapper;
    }
    public async Task<PostInformationResponseDTO> Handle(CreatePostInformationRecord request, CancellationToken cancellationToken)
    {
        var mapModel = _mapper.Map<PostInformation>(request);
        var res = await _postInformationCommandService.AddAsync(mapModel);
        var mapResult = _mapper.Map<PostInformationResponseDTO>(res);
        return mapResult;
    }
}