using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MonthGetterTest
    {
        [TestMethod]
        public void Get1mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual(getter.Get("M", dateTime), "3");
        }
        [TestMethod]
        public void Get2mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual(getter.Get("MM", dateTime), "03");
        }
        [TestMethod]
        public void Get3mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual(getter.Get("MMM", dateTime), "Mar");
        }
        [TestMethod]
        public void Get4mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual(getter.Get("MMMM", dateTime), "March");
        }
        public void GetManyMTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.IsNull(getter.Get("MMMMM", dateTime));
        }
    }
}
