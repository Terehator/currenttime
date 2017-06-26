using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressTestProject.PageObjects
{
    class HomePage
    {
        private By usernameLocator = By.XPath("//span[@class=\"display-name\"]");
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetUsername()
        {
            return driver.FindElement(usernameLocator).Text;
        }
    }
}
