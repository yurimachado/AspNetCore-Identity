namespace Identity.Service.Application.Commands.User.Notification
{
    // Configuration related to any kind of notification related to the Identity management context.
    public class NotificationConfiguration
    {
        public string EmailConfirmationUrl { get; set; }
        public string ResetPassowordUrl { get; set; }
    }
}