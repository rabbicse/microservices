using System.ComponentModel.DataAnnotations;

public class PostInformation
{
    [Key]
    public string Id { get; set; }
    public string Title { get; set; }
    public string UserName { get; set; }
    public DateTime CreatedDate { get; set; }
}