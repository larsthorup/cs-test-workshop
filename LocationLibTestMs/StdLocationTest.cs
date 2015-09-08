using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocationLib;

namespace LocationLibTest
{
    [TestClass]
    public class StdLocationTest
    {
        [TestMethod]
        public void ToDisplayString_InsideUsa()
        {
            var location = new StdLocation { CountryCode = "US", Region = "California", City = "San Francisco" };
            Assert.AreEqual("San Francisco, California", location.ToDisplayString());
        }

        [TestMethod]
        public void ToDisplayString_OutsideUsa()
        {
            var location = new StdLocation { CountryCode = "DK", Country = "Denmark", Region = "Hovedstaden", City = "Farum" };
            Assert.AreEqual("Farum, Denmark", location.ToDisplayString());
        }

        [TestMethod]
        public void ToDisplayString_NoCity()
        {
            var location = new StdLocation { CountryCode = "PH", Country = "Philippines", Region = "", City = "" };
            Assert.AreEqual("Philippines", location.ToDisplayString());
        }
    }
}
