using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class DayTimeOutputerTest
    {
        [TestMethod]
        public void GetNormalInputTest()
        {
            DayTimeOutputer outputer = new DayTimeOutputer();
            List<string> list = new List<string>();
            list.Add("hh");
            list.Add("mm");
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            Assert.AreEqual("04:30", outputer.Output("hh:mm", dateTime, list));
        }
        [TestMethod]
        public void GetEmptyInputTest()
        {
            DayTimeOutputer outputer = new DayTimeOutputer();
            List<string> list = new List<string>();
            DateTime dateTime = new DateTime(1997, 3, 3, 4, 30, 30);
            Assert.AreEqual("12:12", outputer.Output("12:12", dateTime, list));
        }
    }
}
