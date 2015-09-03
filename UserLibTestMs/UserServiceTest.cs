using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserLib;
using UserServiceTestMs;

namespace UserLibTestMs
{
    [TestClass]
    public class UserLibTest
    {
        [TestMethod]
        public void Deactivate()
        {
            var context = new ContextBuilder
            {
                Users = new []
                {
                    new User { Name = "Lars", IsActive = true },
                },
            }.Build();
            var lars = context.GetUser("Lars");
            var userService = new UserService(context);

            userService.Deactivate(lars.Id);

            Assert.IsFalse(userService.Get(lars.Id).IsActive);
        }
    }
}
