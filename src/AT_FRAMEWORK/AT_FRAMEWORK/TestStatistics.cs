using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK
{
    class TestStatistics
    {
        int passedTests = 0;

        public int PassedTests
        {
            get { return passedTests; }
            set { passedTests = value; }
        }
        int unpassedTests = 0;

        public int UnpassedTests
        {
            get { return unpassedTests; }
            set { unpassedTests = value; }
        }
        long totalTime = 0;

        public long TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }
    }
}
