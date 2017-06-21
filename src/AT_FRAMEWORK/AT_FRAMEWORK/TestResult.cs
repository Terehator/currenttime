using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK
{
    /// <summary>
    /// Test rsult class
    /// </summary>
    class TestResult
    {
        private bool result;

        public bool Result
        {
            get { return result; }
            set { result = value; }
        }
        private long time;
        
        public TestResult(bool result, long time)
        {
            this.result = result;
            this.time = time;
        }

        public long Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
