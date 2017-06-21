using AT_FRAMEWORK.CommandBuilders;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK
{
    class Program
    {
        const int WAIT_TIME = 120;
        const string OUTPUT_FILENAME = "output.txt";
        const string INPUT_FILENAME = "input.txt";
        static void Main(string[] args)
        {
            CommandReader comandReader = new CommandReader(INPUT_FILENAME);
            TxtLogger logger = new TxtLogger(OUTPUT_FILENAME);
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArgument("test-type");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("no-sandbox");
            ChromeDriver webDriver = new ChromeDriver(options);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAIT_TIME);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(WAIT_TIME);
            PageTester pageTester = new PageTester(webDriver);
            ComandCreator comandCreator = new OpenComandCreator(
                                          new CheckLinkPresentByHrefComandCreator(
                                          new CheckLinkPresentByNameComandCreator(
                                          new CheckPageContainsComandCreator(
                                          new CheckPageTitleComandCreator(null)))));
            string command = comandReader.ReadNextComandFromFile();
            while (command != null)
            {
                try
                {
                    logger.LogComandResult(comandCreator.GetCommand(command).Invoke(pageTester), command);
                    command = comandReader.ReadNextComandFromFile();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            logger.LogStatistics(pageTester.TestStatistics);
        }
    }
}
