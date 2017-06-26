using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressTestProject.TestResultsLoggers;

namespace WordPressTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester(new TxtTestResultsLogger(), new ChromeDriver());
            tester.TestLogin();
            Console.Read();
        }
    }
}
