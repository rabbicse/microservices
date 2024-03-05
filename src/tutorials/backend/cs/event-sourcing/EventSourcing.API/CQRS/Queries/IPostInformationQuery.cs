public interface IPostInformationQuery
{
    IEnumerable<PostInformation> GetAllPosts();
    PostInformation GetById(string id);
}