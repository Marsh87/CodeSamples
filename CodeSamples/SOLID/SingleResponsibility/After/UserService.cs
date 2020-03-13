using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.SOLID.SingleResponsibility.Models;

namespace CodeSamples.SOLID.SingleResponsibility.After
{
    public class UserService
    {
        private readonly IEmailService _emailService;

        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);
           await _emailService.SendEmail(new MailMessage("mymail@mail.com", email) { Subject = "New Mail" });
        }
    }
}
