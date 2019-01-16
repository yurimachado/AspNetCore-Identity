using Microsoft.AspNetCore.Identity;

namespace Identity.Service.Application
{
    public class ApplicationUser : IdentityUser
    {
        public string RoleName { get; set; }
        public bool IsAdmin {
            get => (this.RoleName == null) ? false : this.RoleName.ToUpper() == "ADMIN";
        }
        public bool IsBlocked { get; set; }
    }
}
