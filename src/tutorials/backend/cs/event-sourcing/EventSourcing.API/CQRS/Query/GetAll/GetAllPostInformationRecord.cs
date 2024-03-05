using MediatR;

public record GetAllPostInformationRecord 
(
): IRequest<IEnumerable<PostInformationResponseDTO>>;