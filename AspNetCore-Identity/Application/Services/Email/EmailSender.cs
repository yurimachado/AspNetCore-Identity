using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Identity.Service.Application.Services.Email
{
    public class EmailSender : IEmailSender
    {
        // Our private configuration variables
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        // Get our parameterized configuration
        public EmailSender(IOptions<SmtpSettings> options)
        {
            var settings = options.Value;
            this._host = settings.Host;
            this._port = settings.Port;
            this._enableSSL = settings.EnableSSL;
            this._userName = settings.UserName;
            this._password = settings.Password;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(this._userName, this._password),
                EnableSsl = this._enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(this._userName, email, subject, htmlMessage) { IsBodyHtml = true }
            );
        }
    }
}
