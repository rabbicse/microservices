public interface IPostInformationCommandService
{
    Task<PostInformation> AddAsync(PostInformation postInformation);

    // Add another commands like update or delete
}