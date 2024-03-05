public interface IPostInformationCommand
{
    Task<PostInformation> AddAsync(PostInformation postInformation);

    // Add another commands like update or delete
}