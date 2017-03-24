using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;

namespace AT_1
{
    [TestClass]
    public class IETest : Test
    {
        [TestInitialize]
        override public void ChromeInit()
        {
            driver = new InternetExplorerDriver();
        }
    }
}
