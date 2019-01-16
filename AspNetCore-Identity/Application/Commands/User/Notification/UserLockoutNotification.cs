using MediatR;
using System;

namespace Identity.Service.Application.Commands.User.Notification
{
    public class UserLockoutNotification : INotification
    {
        public ApplicationUser User { get; set; }
        public DateTime DatetimeOfLockout { get; set; }
    }
}
