using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailLib;
using NSubstitute;

namespace EmailLibTestMs
{
    [TestClass]
    public class NotifierTest
    {
        private IEmailService emailService;
        private Notifier notifier;

        [TestInitialize]
        public void Initialize()
        {
            emailService = Substitute.For<IEmailService>();
            notifier = new Notifier(emailService);
        }

        [TestMethod]
        public void Trigger()
        {
            emailService.SendEmail(Arg.Any<Email>()).Returns(true);

            notifier.Trigger("New highscore: 150");

            emailService.Received().SendEmail(new Email { Body = "New highscore: 150" });
        }

        [TestMethod]
        public void Trigger_Error()
        {
            emailService.SendEmail(Arg.Any<Email>()).Returns(false);

            try
            {
                notifier.Trigger("New highscore: 0");
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("Failed to send email", ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Trigger_Error_ExpectedException()
        {
            emailService.SendEmail(Arg.Any<Email>()).Returns(false);

            notifier.Trigger("New highscore: 0");
        }
    }
}
