using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

namespace UnitTests
{
    [TestClass]
    public class SecondGetterTest
    {
        [TestMethod]
        public void Get1sTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            SecondGetter getter = new SecondGetter();
            Assert.AreEqual("4", getter.Get("s", dateTime));
        }

        [TestMethod]
        public void Get2sTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            SecondGetter getter = new SecondGetter();
            Assert.AreEqual("04", getter.Get("ss", dateTime));
        }

        [TestMethod]
        public void GetManySTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            SecondGetter getter = new SecondGetter();
            Assert.IsNull(getter.Get("ssss", dateTime));
        }
    }
}
