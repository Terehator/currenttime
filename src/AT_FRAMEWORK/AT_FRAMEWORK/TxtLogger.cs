using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK
{
    /// <summary>
    /// Log to txt file
    /// </summary>
    class TxtLogger
    {
        string trueSym = "+";
        string falseSym = "!";
        string filename;

        public TxtLogger(string filename)
        {
            this.filename = filename;
        }
        
        /// <summary>
        /// Log results of testing
        /// </summary>
        /// <param name="testResult"></param>
        /// <param name="line"></param>
        public void LogComandResult(TestResult testResult, string line)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                string resultLine = string.Empty;
                if (testResult.Result == true)
                    resultLine = trueSym;
                else
                    resultLine = falseSym;
                resultLine = string.Concat(resultLine, ' ', '[', line, ']', ' ', (testResult.Time / 1000.0).ToString());
                writer.WriteLine(resultLine);
            }
        }

        /// <summary>
        /// Log test statstics
        /// </summary>
        /// <param name="testStatistics"></param>
        public void LogStatistics(TestStatistics testStatistics)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                string resultLine = string.Empty;
                resultLine = string.Concat("Total tests: ", (testStatistics.PassedTests + testStatistics.UnpassedTests).ToString(), '\n');
                resultLine = string.Concat(resultLine, "Passes/Failed: ", testStatistics.PassedTests.ToString(), '/', testStatistics.UnpassedTests.ToString(), '\n');
                resultLine = string.Concat(resultLine, "Total time: ", (testStatistics.TotalTime / 1000.0).ToString(), '\n');
                resultLine = string.Concat(resultLine, "Average time: ", (testStatistics.TotalTime / (testStatistics.PassedTests + testStatistics.UnpassedTests)).ToString(), '\n');
                writer.WriteLine(resultLine);
            }
        }
    }
}
