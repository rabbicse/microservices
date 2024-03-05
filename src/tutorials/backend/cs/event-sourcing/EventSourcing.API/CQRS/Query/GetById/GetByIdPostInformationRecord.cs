using MediatR;

public record GetByIdPostInformationRecord
(
    string Id
) : IRequest<PostInformationResponseDTO>;