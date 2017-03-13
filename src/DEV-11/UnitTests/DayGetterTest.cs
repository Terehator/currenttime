using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DayGetterTest
    {
        [TestMethod]
        public void Get1dTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3);
            DayGetter getter = new DayGetter();
            Assert.AreEqual(getter.Get("d", dateTime), "3");
        }
        public void Get2dTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3);
            DayGetter getter = new DayGetter();
            Assert.AreEqual(getter.Get("dd", dateTime), "03");
        }
        public void GetManyDTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3);
            DayGetter getter = new DayGetter();
            Assert.IsNull(getter.Get("ddddd", dateTime));
        }
    }
}
