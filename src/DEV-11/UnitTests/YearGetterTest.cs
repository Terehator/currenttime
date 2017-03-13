using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV-6;

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
            Assert.AreEqual(yearGetter.Get("yy", dateTime), "97");
        }
        [TestMethod]
        public void Get3yTest()
        {
            DateTime dateTime = new DateTime(1997,12,12);
            YearGetter yearGetter = new YearGetter();
            Assert.AreEqual(yearGetter.Get("yyy", dateTime), "997");
        }
        [TestMethod]
        public void Get4yTest()
        {
            DateTime dateTime = new DateTime(1997,12,12);
            YearGetter yearGetter = new YearGetter();
            Assert.AreEqual(yearGetter.Get("yyyy", dateTime), "1997");
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
