using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AT_1
{
    [TestClass]
    public class Test
    {
        static IWebDriver driver;
        static LoginPage loginPage;
        static HomePage homePage;
        string url = "http://www.mail.ru";
        string loginFieldId = "mailbox__login";
        string passwordFieldId = "mailbox__password";
        string loginButtonId = "mailbox__auth__button";
        string validLogin = "tat-dev13";
        string validPass = "23.03.2017";
        string lettersId = "b-letters";
        string errorClassName = "b-login__errors";

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [ClassInitialize()]
        static public void ChromeInit(TestContext context)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArgument("test-type");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            driver.Navigate().GoToUrl(url);
            loginPage.clearFields();
        }

        [DataSource(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\User\src\AT-1\Data\Database.accdb;", "Logins")]
        [TestMethod()]
        public void PossitiveLoginFormTest()
        {
            bool isPossitive = bool.Parse(TestContext.DataRow["IsResultPossitive"].ToString());
            loginPage.setUserName(TestContext.DataRow["Username"].ToString());
            loginPage.setPassword(TestContext.DataRow["Password"].ToString());
            loginPage.clickLoginButton();
            if (isPossitive)
                Assert.AreEqual(true, homePage.isLogoutHere());
            else
                Assert.AreEqual(true, homePage.isErrorHere());
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            homePage.logout();
        }

        [ClassCleanup()]
        static public void CleanUp()
        {
            driver.Close();
        }
        /*
        [TestMethod]
        public void UpperLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin.ToUpper());
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass.ToUpper());
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void WrongLoginAndPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("tat-dev1314");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("kalmac");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void SwapLoginAndPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void WrongLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("tat-dev1314");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void WrongPaswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("adga");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void EmptyLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void EmptyPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void BigLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("ajdvkkkkkkkkkkkklskoavasvnpawsfsdbdbvmewsvvvvm");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void BigPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("dfnnnnnnnnnnnnnnnnnnnnnnnnnnnassssssssssss");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void WithSpaceLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(string.Concat(" ", validLogin, " "));
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.Id(lettersId)));
        }

        [TestMethod]
        public void WithSpacesPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(string.Concat(" ", validPass, " "));
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void SpecialSymbolsLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(@"♣☺♂” , “”‘~!@#$%^&*()?>,./\<][ /*<!–“”, “${code}");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void ScriptInLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("<script>alert(“Hello, world!”)</alert>");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void ScriptInPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("<script>alert(“Hello, world!”)</alert>");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void HTMLInLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("<form action=”http://live.hh.ru”><input type=”submit”></form>");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void HTMLInPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("<form action=”http://live.hh.ru”><input type=”submit”></form>");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void CirilicInLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("Василий");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void CirilicInPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys("Василий");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }

        [TestMethod]
        public void OnlySpacesInLoginFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys("           ");
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(validPass);
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }
        
        [TestMethod]
        public void SpecialSymbolsPasswordFormTest()
        {
            driver.Navigate().GoToUrl("http://www.mail.ru");
            driver.FindElement(By.Id(loginFieldId)).SendKeys(validLogin);
            driver.FindElement(By.Id(passwordFieldId)).SendKeys(@"♣☺♂” , “”‘~!@#$%^&*()?>,./\<][ /*<!–“”, “${code}");
            driver.FindElement(By.Id(loginButtonId)).Click();
            Assert.IsNotNull(driver.FindElement(By.ClassName(errorClassName)));
        }
        */
        
    }
}
