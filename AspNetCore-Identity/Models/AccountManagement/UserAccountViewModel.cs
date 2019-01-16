using System;

namespace Identity.Service.Models
{
    public class UserAccountViewModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool IsBlocked { get; set; }
        public int AccessFailedCount { get; set; }
        public bool TwoFactorEnabled { get; set; } //Needs implementation
        public bool PhoneNumberConfirmed { get; set; }//Needs implementation to check the confirmation must be done either through phone or email (default)
        public string PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool IsAdmin { get; set; }
    }
}
