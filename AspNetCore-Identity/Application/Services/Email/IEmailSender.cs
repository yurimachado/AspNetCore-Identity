using System.Threading.Tasks;

namespace Identity.Service.Application.Services.Email
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
