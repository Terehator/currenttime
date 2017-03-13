using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

namespace UnitTests
{
    [TestClass]
    public class HourGetterTest
    {
        [TestMethod]
        public void Get1hTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            HourGetter getter = new HourGetter();
            Assert.AreEqual("4", getter.Get("h", dateTime));
        }

        [TestMethod]
        public void Get2hTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            HourGetter getter = new HourGetter();
            Assert.AreEqual("04", getter.Get("hh", dateTime));
        }

        [TestMethod]
        public void GetManyHTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            HourGetter getter = new HourGetter();
            Assert.IsNull(getter.Get("hhh", dateTime));
        }
    }
}
