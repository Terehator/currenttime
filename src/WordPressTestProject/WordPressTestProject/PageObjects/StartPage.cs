using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressTestProject.PageObjects
{
    class StartPage
    {
        public static string startPageURL = "http://localhost:8888/";
        private By logInLocator = By.XPath("//*[@id=\"meta-2\"]/ul/li[1]/a");
        private IWebDriver driver;
        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage GetLoginPage()
        {
            driver.FindElement(logInLocator).Click();
            return new LoginPage(driver);
        }
    }
}
