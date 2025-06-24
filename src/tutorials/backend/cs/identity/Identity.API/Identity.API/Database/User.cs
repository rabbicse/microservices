using Microsoft.AspNetCore.Identity;

namespace Identity.API.Database;

public class User: IdentityUser
{
    public string? Initials { get; set; }
}
