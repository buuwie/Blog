using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Ten {  get; set; }
        public string? Ho {  get; set; }
        public List<Post>? Posts { get; set; }

    }
}
