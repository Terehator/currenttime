using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace AT_1
{
    [TestClass]
    public class FirefoxTest : Test
    {
        [TestInitialize]
        override public void ChromeInit()
        {
            driver = new FirefoxDriver();
        }
    }
}
