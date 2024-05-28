public class PostInformationQueryService : IPostInformationQueryService
{
    private readonly AppDbContext _dbContext;

    public PostInformationQueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<PostInformation> GetAllPosts()
    {
        return _dbContext.PostInformation.OrderByDescending(p => p.CreatedDate).ToList();
    }

    public PostInformation GetById(string id)
    {
        return _dbContext.PostInformation.FirstOrDefault(p => p.Id == id);
    }
}