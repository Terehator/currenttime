using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class HourGetterTest
    {
        public void Get1hTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            HourGetter getter = new HourGetter();
            Assert.AreEqual(getter.Get("h", dateTime), "4");
        }
        public void Get2hTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            HourGetter getter = new HourGetter();
            Assert.AreEqual(getter.Get("hh", dateTime), "04");
        }
        public void GetManyHTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            HourGetter getter = new HourGetter();
            Assert.IsNull(getter.Get("hhh", dateTime));
        }
    }
}
