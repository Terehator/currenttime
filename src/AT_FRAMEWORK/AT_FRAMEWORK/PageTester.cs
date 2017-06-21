using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK
{
    class PageTester
    {
        PageObject page;
        IWebDriver webDriver;
        TestStatistics testStatistics;

        internal TestStatistics TestStatistics
        {
            get { return testStatistics; }
        }

        public PageTester(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            page = new PageObject(webDriver);
            testStatistics = new TestStatistics(); 
        }

        /// <summary>
        /// Check open page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public TestResult Open(string url, int timeout)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Console.WriteLine(string.Concat("Opening ", url));
            sw.Start();
            page.Open(url, timeout);
            sw.Stop();
            if (sw.ElapsedMilliseconds < timeout)
                testStatistics.UnpassedTests++;
            else
                testStatistics.PassedTests++;
            testStatistics.TotalTime += sw.ElapsedMilliseconds; 
            return new TestResult(sw.ElapsedMilliseconds < timeout, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Check page title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public TestResult CheckPageTitle(string title)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool result = page.CheckPageTitle(title);
            sw.Stop();
            if (result)
                testStatistics.UnpassedTests++;
            else
                testStatistics.PassedTests++;
            testStatistics.TotalTime += sw.ElapsedMilliseconds;
            return new TestResult(result, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Check page contains
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public TestResult CheckPageContains(string text)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool result = page.CheckPageContains(text);
            sw.Stop();
            if (result)
                testStatistics.UnpassedTests++;
            else
                testStatistics.PassedTests++;
            testStatistics.TotalTime += sw.ElapsedMilliseconds;
            return new TestResult(result, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Check link by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TestResult CheckLinkPresentByName(string name)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool result = page.CheckLinkPresentByName(name);
            sw.Stop();
            if (result)
                testStatistics.UnpassedTests++;
            else
                testStatistics.PassedTests++;
            testStatistics.TotalTime += sw.ElapsedMilliseconds;
            return new TestResult(result, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Check link by href
        /// </summary>
        /// <param name="href"></param>
        /// <returns></returns>
        public TestResult CheckLinkPresentByHref(string href)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool result = page.CheckLinkPresentByHref(href);
            sw.Stop();
            if (result)
                testStatistics.UnpassedTests++;
            else
                testStatistics.PassedTests++;
            testStatistics.TotalTime += sw.ElapsedMilliseconds;
            return new TestResult(result, sw.ElapsedMilliseconds);
        }
    }
}
