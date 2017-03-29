using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

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
            Assert.AreEqual("3", getter.Get("M", dateTime));
        }

        [TestMethod]
        public void Get2mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual("03", getter.Get("MM", dateTime));
        }

        [TestMethod]
        public void Get3mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual("Mar", getter.Get("MMM", dateTime));
        }

        [TestMethod]
        public void Get4mTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.AreEqual("March", getter.Get("MMMM", dateTime));
        }

        [TestMethod]
        public void GetManyMTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 12);
            MonthGetter getter = new MonthGetter();
            Assert.IsNull(getter.Get("MMMMM", dateTime));
        }
    }
}
