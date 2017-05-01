using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.Comands
{
    class CheckPageTitleComand : IComand
    {
        string title;

        public CheckPageTitleComand(string title)
        {
            this.title = title;
        }

        public TestResult Invoke(PageTester comandInvoker)
        {
            return comandInvoker.CheckPageTitle(title);
        }
    }
}
