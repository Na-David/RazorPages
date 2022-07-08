using Microsoft.AspNetCore.Identity;

namespace ZeroBase.Models
{
    public partial class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
