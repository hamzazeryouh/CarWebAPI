using Microsoft.AspNetCore.Identity;

namespace CarWebAPI.Entities.Domain
{
    public class User:IdentityUser
    {
        public string? Avatar { get; set; }
    }
}
