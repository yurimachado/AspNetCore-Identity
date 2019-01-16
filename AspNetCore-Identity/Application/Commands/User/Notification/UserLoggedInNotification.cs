using MediatR;
using System;

namespace Identity.Service.Application.Commands.User.Notification
{
    public class UserLoggedInNotification : INotification
    {
        public ApplicationUser User { get; set; }
        public DateTime DatetimeUserLoggedIn { get; set; }
    }
}
