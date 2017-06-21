using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.Comands
{
    class CheckLinkByPresentHrefComand : IComand
    {
        string href;

        public CheckLinkByPresentHrefComand(string href)
        {
            this.href = href;
        }

        public TestResult Invoke(PageTester comandInvoker)
        {
            return comandInvoker.CheckLinkPresentByHref(href);
        }
    }
}
