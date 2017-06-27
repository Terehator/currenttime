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
            //Tester tester = new Tester(new TxtTestResultsLogger(), new ChromeDriver());
            //tester.TestLogin();
            using (LoginTestCaseContext db = new LoginTestCaseContext())
            {
                var test = db.LoginTestCases;
                LoginTestCase asa = new LoginTestCase();
                asa.Id = 2;
                asa.Password = "asd";
                asa.Username = "asd";
                db.LoginTestCases.Add(asa);
                db.SaveChanges();
                foreach (LoginTestCase l in test)
                {
                    Console.WriteLine(l.Id);
                }
            }
            Console.Read();
        }
    }
}
