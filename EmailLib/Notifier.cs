using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailLib
{
    public class Notifier
    {
        private IEmailService emailService;

        public Notifier(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void Trigger(string message)
        {
            var email = new Email { Body = message };
            emailService.SendEmail(email);
        }
    }
}
