using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserLib;
using NSubstitute;

namespace UserLibTestMs
{
    [TestClass]
    public class UserServiceTest_NSubstitute
    {
        [TestMethod]
        public void Deactivate()
        {
            var context = Substitute.For<IContext>();
            var lars = new User { Id = 47 };
            context.GetUser(47).Returns(lars);
            var userService = new UserService(context);

            userService.Deactivate(47);

            Assert.IsFalse(userService.Get(47).IsActive);
        }
    }
}
