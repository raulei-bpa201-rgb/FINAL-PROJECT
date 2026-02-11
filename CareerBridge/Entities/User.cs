using Microsoft.AspNetCore.Identity;

namespace JobPortal.Api.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
