using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressTestProject.PageObjects;
using System.Diagnostics;

namespace WordPressTestProject
{
    class Tester
    {
        private ITestResultsLogger testLogger;
        private IWebDriver driver;
  
        public Tester(ITestResultsLogger testLogger, IWebDriver driver)
        {
            this.testLogger = testLogger;
            this.driver = driver;
        }

        public void TestLogin()
        {
            using (LoginTestCaseContext db = new LoginTestCaseContext())
            {
                var testCases = db.LoginTestCases;
                foreach (LoginTestCase testCase in testCases)
                {
                    Console.WriteLine(testCase.Id);
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    driver.Url = StartPage.startPageURL;
                    driver.Navigate();
                    if (testCase.IsPossitive)
                        if ((new StartPage(driver))
                            .GetLoginPage()
                            .LoginAs(testCase.Username, testCase.Password)
                            .GetUsername().Equals(testCase.Username))
                        {
                            sw.Stop();
                            testLogger.Log(testCase.Id, true, (int)sw.ElapsedMilliseconds);
                        }
                        else
                        {
                            sw.Stop();
                            testLogger.Log(testCase.Id, false, (int)sw.ElapsedMilliseconds);
                        }
                    else
                        {
                            sw.Stop();
                            testLogger.Log(testCase.Id, (new StartPage(driver))                            .GetLoginPage()
                            .ExpectingFailureLoginAs(testCase.Username, testCase.Password)
                            .IsError(), (int)sw.ElapsedMilliseconds);
                        }
                }
            }
        }
    }
}
