using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

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
            Assert.AreEqual("3", getter.Get("d", dateTime));
        }

        [TestMethod]
        public void Get2dTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3);
            DayGetter getter = new DayGetter();
            Assert.AreEqual("03", getter.Get("dd", dateTime));
        }

        [TestMethod]
        public void GetManyDTest()
        {
            DateTime dateTime = new DateTime(1997, 3, 3);
            DayGetter getter = new DayGetter();
            Assert.IsNull(getter.Get("ddddd", dateTime));
        }
    }
}
