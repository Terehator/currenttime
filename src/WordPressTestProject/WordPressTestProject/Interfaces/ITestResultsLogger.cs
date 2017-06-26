using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressTestProject
{
    interface ITestResultsLogger
    {
        void Log(int testName, bool isPassed, int time);
    }
}
