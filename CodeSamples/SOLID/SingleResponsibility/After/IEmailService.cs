using System.Net.Mail;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.SingleResponsibility.After
{
    public interface IEmailService
    {
        bool ValidateEmail(string email);

        Task SendEmail(MailMessage message);
    }
}