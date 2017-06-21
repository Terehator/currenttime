using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.Comands
{
    class CheckPageContainsComand : IComand
    {
        string text;

        public CheckPageContainsComand(string text)
        {
            this.text = text;
        }

        public TestResult Invoke(PageTester comandInvoker)
        {
            return comandInvoker.CheckPageContains(text);
        }
    }
}
