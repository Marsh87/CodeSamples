using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.SingleResponsibility.Before
{
    public class EmailService:IEmailService
    {
        public bool ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(MailMessage message)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmailService
    {
        bool ValidateEmail(string email);

        void SendEmail(MailMessage message);
    }
}
