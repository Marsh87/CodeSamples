using System;
using System.Net.Mail;

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
            throw new NotImplementedException();
        }

        public void SendEmail(MailMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
