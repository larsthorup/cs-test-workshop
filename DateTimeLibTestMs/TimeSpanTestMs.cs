using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateTimeLib;

namespace DateTimeLibTestMs
{
    [TestClass]
    public class TimeSpanTestMs
    {
        [TestMethod]
        public void ToDisplayString_Now()
        {
            Assert.AreEqual("now", TimeSpan.FromSeconds(4).ToDisplayString());
        }

        [TestMethod]
        public void ToDisplayString_Seconds()
        {
            Assert.AreEqual("5 seconds ago", TimeSpan.FromSeconds(5).ToDisplayString());
        }

        [TestMethod]
        public void ToDisplayString_Minutes()
        {
            Assert.AreEqual("2 minutes ago", TimeSpan.FromMinutes(2).ToDisplayString());
        }
    
    }
}
