using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WordPressTestProject.PageObjects
{
    class LoginPage
    {
        private By usernameLocator = By.XPath("//input[@id=\"user_login\"]");
        private By passwordLocator = By.XPath("//input[@id=\"user_pass\"]");
        private By loginButtonLocator = By.XPath("//input[@id=\"wp-submit\"]");
        private By errorElementLocator = By.XPath("//div[@id=\"login_error\"]");

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsError()
        {
            return driver.FindElements(errorElementLocator).Count > 0;
        }

        public LoginPage TypeUsername(String username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
            return this;    
        }

        public LoginPage TypePassword(String password) 
        {
            driver.FindElement(passwordLocator).SendKeys(password);
            return this;    
        }

        public HomePage SubmitLogin() 
        {
            driver.FindElement(loginButtonLocator).Submit();
            return new HomePage(driver);    
        }

        public LoginPage ExpectingFailureLoginAs(String username, String password)
        {
            TypeUsername(username);
            TypePassword(password);
            SubmitLogin();
            return new LoginPage(driver);   
        }

        public HomePage LoginAs(String username, String password) 
        {
            TypeUsername(username);
            TypePassword(password);
            return SubmitLogin();
        }
    }
}
