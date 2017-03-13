using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual(getter.Get("s", dateTime), "4");
        }
        [TestMethod]
        public void Get2sTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            SecondGetter getter = new SecondGetter();
            Assert.AreEqual(getter.Get("ss", dateTime), "04");
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
