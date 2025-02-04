using Microsoft.AspNetCore.Identity;

namespace JH_LAB1.Models
{
    public class AppUser : IdentityUser
    {
        public string? RoleId { get; set; }
    }
}
