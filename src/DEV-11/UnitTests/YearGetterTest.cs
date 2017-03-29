using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

namespace UnitTests
{
    [TestClass]
    public class YearGetterTest
    {
        [TestMethod]
        public void Get2yTest()
        {
            DateTime dateTime = new DateTime(1997,12,12);
            YearGetter yearGetter = new YearGetter();
            Assert.AreEqual("97", yearGetter.Get("yy", dateTime));
        }

        [TestMethod]
        public void Get3yTest()
        {
            DateTime dateTime = new DateTime(1997,12,12);
            YearGetter yearGetter = new YearGetter();
            Assert.AreEqual("997", yearGetter.Get("yyy", dateTime));
        }

        [TestMethod]
        public void Get4yTest()
        {
            DateTime dateTime = new DateTime(1997,12,12);
            YearGetter yearGetter = new YearGetter();
            Assert.AreEqual("1997", yearGetter.Get("yyyy", dateTime));
        }

        [TestMethod]
        public void GetManyYTest()
        {
            DateTime dateTime = new DateTime(1997,12,12);
            YearGetter yearGetter = new YearGetter();
            Assert.AreEqual(yearGetter.Get("yyyyy", dateTime), null);
        }
    }
}
