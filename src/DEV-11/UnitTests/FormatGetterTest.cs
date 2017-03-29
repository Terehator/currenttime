using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DEV_6;

namespace UnitTests
{
    [TestClass]
    public class FormatGetterTest
    {
        [TestMethod]
        public void GetNormalInputTest()
        {
            FormatGetter getter = new FormatGetter();
            List<string> list = new List<string>();
            list.Add("hh");
            list.Add("mm");
            CollectionAssert.AreEqual(list, getter.Get("hh:mm"));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Not allowed format")]
        public void GetInvalidInputTest()
        {
            FormatGetter getter = new FormatGetter();
            List<string> list = getter.Get("hhs:mm");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Empty line")]
        public void GetEmptyInputTest()
        {
            FormatGetter getter = new FormatGetter();
            List<string> list = getter.Get(string.Empty);
        }
    }
}
