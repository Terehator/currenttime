using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.Comands
{
    interface IComand
    {
        TestResult Invoke(PageTester comandInvoker);
    }
}
