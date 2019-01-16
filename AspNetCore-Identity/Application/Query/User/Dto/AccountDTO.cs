namespace Identity.Service.Application.Query.User.Dto
{
    public class AccountDTO
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool IsBlocked { get; set; }
        public int AccessFailedCount { get; set; }
        public bool TwoFactorEnabled { get; set; } 
        public bool PhoneNumberConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool IsAdmin { get; set; }
    }
}
