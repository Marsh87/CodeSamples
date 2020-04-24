using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.SingleResponsibility.After
{
    public class EmailService:IEmailService
    {
        private readonly SmtpClient _smtpClient;

        public EmailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public async Task SendEmail(MailMessage message)
        {
            await _smtpClient.SendMailAsync(message);
        }
    }
}
