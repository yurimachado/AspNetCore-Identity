using MediatR;
using System;

namespace Identity.Service.Application.Commands.User.Notification
{
    public class AccessFailedNotification : INotification
    {
        public ApplicationUser User { get; set; }
        public DateTime DatetimeAccessFailed { get; set; }
    }
}
