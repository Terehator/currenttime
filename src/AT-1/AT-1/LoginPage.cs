using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_1
{
    public class LoginPage
    {
        IWebDriver driver;
        By userNameField = By.Id("mailbox__login");
        By passwordField = By.Id("mailbox__password");
        By loginButton = By.Id("mailbox__auth__button");

        public void clearFields()
        {
            driver.FindElement(userNameField).Clear();
            driver.FindElement(passwordField).Clear();
        }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void setUserName(string user)
        {
            driver.FindElement(userNameField).SendKeys(user);
        }

        public void setPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void clickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
