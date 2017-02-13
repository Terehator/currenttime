using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Program //Main class
    {
        static void Main(string[] args)
        {
            LineGetter lineGetter = new LineGetter();
            if (lineGetter.isLineGettingSuccesfull(args) == true)
            {
                Counter counter = new Counter();
                Console.WriteLine(counter.count(lineGetter.getNumbers(), lineGetter.getSignes()));
            }
            Console.ReadKey();
        }
    }
}
