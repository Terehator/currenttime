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
        
    }
}
