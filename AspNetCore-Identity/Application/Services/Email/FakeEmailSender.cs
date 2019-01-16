using System.Threading.Tasks;

namespace Identity.Service.Application.Services.Email
{
    public class FakeEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            System.IO.File.WriteAllTextAsync(subject, htmlMessage);
            return Task.CompletedTask;
        }
    }
}
