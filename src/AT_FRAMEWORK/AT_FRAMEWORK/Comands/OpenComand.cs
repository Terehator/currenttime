using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.Comands
{
    class OpenComand : IComand
    {
        string url;
        int timeout;

        public OpenComand(string url, int timeout)
        {
            this.url = url;
            this.timeout = timeout;
        }

        public TestResult Invoke(PageTester comandInvoker)
        {
            return comandInvoker.Open(url, timeout);
        }
    }
}
