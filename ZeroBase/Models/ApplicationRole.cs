using Microsoft.AspNetCore.Identity;

namespace ZeroBase.Models
{
    public partial class ApplicationUser
    {
        public class ApplicationRole : IdentityRole
        {
            public string Description { get; set; }
        }
    }
}
