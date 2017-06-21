using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.Comands
{
    class CheckLinkByPresentNameComand : IComand
    {
        string name;

        public CheckLinkByPresentNameComand(string name)
        {
            this.name = name;
        }

        public TestResult Invoke(PageTester comandInvoker)
        {
            return comandInvoker.CheckLinkPresentByName(name);
        }
    }
}
