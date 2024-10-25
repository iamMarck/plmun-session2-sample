using Microsoft.AspNetCore.Identity;

namespace Sample.Models
{
    public class UserAccount: IdentityUser<long>
    {
        public string? Address { get; set; }
        public bool IsMember { get; set; }
    }
}
