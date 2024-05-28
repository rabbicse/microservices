public interface IPostInformationQueryService
{
    IEnumerable<PostInformation> GetAllPosts();
    PostInformation GetById(string id);
}