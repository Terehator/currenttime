using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

namespace UnitTests
{
    [TestClass]
    public class MinuteGetterTest
    {
        [TestMethod]
        public void Get1mTest()
        {
            DateTime dateTime = new DateTime(1997, 2, 12, 4, 4, 4);
            MinuteGetter getter = new MinuteGetter();
            Assert.AreEqual("4", getter.Get("m", dateTime));
        }

        [TestMethod]
        public void Get2mTest()
        {
            DateTime dateTime = new DateTime(1997, 2, 12, 4, 4, 4);
            MinuteGetter getter = new MinuteGetter();
            Assert.AreEqual("04", getter.Get("mm", dateTime));
        }

        [TestMethod]
        public void GetManyMTest()
        {
            DateTime dateTime = new DateTime(1997, 2, 12, 4, 4, 4);
            MinuteGetter getter = new MinuteGetter();
            Assert.IsNull(getter.Get("mmm", dateTime));
        }
    }
}
