public class PostInformationCommandHandler : IPostInformationCommand
{
    private readonly AppDbContext _dbContext;

    public PostInformationCommandHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<PostInformation> AddAsync(PostInformation postInformation)
    {
        if (postInformation is not null)
        {
            await _dbContext.PostInformation.AddAsync(postInformation);
            await _dbContext.SaveChangesAsync();
        }
        return postInformation;
    }
}