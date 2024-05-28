using MediatR;

public record CreatePostInformationRecord
(
   string Id,
   string Title,
   string UserName, 
   DateTime CreatedDate
) : IRequest<PostInformationResponseDTO>;