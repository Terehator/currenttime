using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AT_1
{
    [TestClass]
    public class ChromeTest : Test
    {
        [TestInitialize]
        override public void ChromeInit()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArgument("test-type");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(options);
        }
    }
}
