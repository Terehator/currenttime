using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MinuteGetterTest
    {
        [TestMethod]
        public void Get1mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual(getter.Get("m", dateTime), "4");
        }
        [TestMethod]
        public void Get2mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual(getter.Get("mm", dateTime), "04");
        }
        [TestMethod]
        public void GetManyMTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12, 4, 4, 4);
            MonthGetter getter = new MonthGetter();
            Assert.IsNull(getter.Get("mmm", dateTime));
        }
    }
}
