using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatGetter formatGetter = new FormatGetter();
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.Now;
            DateTimeOutputer outputer = new DateTimeOutputer();
            outputer.Output(currentDateTime, formatGetter.Get());
            Console.ReadKey();
        }
    }
}
