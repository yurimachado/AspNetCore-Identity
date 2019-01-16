using MediatR;

namespace Identity.Service.Application.Commands.User.Notification
{

    public class UserRegisteredNotification : INotification
    {
        public ApplicationUser User { get; set; }
        public string Token { get; set; }
    }
}
