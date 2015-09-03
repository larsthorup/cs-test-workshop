using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailLib;
using NSubstitute;

namespace EmailLibTestMsRhino
{
    [TestClass]
    public class NotifierTest
    {
        [TestMethod]
        public void Trigger()
        {
            var emailService = Substitute.For<IEmailService>();
            var notifier = new Notifier(emailService);

            notifier.Trigger("New highscore: 150");

            emailService.Received().SendEmail(new Email { Body = "New highscore: 150" });
        }
    }
}
