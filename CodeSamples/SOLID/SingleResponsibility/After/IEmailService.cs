using System.Net.Mail;

namespace CodeSamples.SOLID.SingleResponsibility.After
{
    public interface IEmailService
    {
        bool ValidateEmail(string email);

        void SendEmail(MailMessage message);
    }
}