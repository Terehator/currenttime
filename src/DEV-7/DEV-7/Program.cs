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
            DateTimeParser dp = new DateTimeParser();
            Date date = new Date();
            Time time = new Time();
            dp.Parse(time, date);
            DateTimeValidator dv = new DateTimeValidator(); 
            Console.WriteLine(dv.Validate(date, time));

        }
    }
}
