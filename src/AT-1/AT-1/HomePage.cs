using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_1
{
    public class HomePage
    {
        IWebDriver driver;
        By errorLabel = By.ClassName("b-login__errors");
        By logoutButton = By.Id("PH_logoutLink");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool isLogoutHere()
        {
            return driver.FindElement(logoutButton) != null;
        }

        public bool isErrorHere()
        {
            return driver.FindElement(errorLabel) != null;
        }

        public void logout()
        {
            driver.FindElement(logoutButton).Click();
        }

    }
}
