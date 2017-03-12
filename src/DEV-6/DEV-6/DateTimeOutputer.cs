using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class DateTimeOutputer
    {
        public void Output(string startLine, DateTime currentTime, List<string> formats)
        {
            string result = string.Copy(startLine);
            foreach (string format in formats)
            {
                switch (format[0])
                {
                    case 'y':
                        {
                            YearGetter getter = new YearGetter();
                            result = result.Replace(format, getter.Get(format, currentTime));
                            break;
                        }
                    case 'M':
                        {
                            MonthGetter getter = new MonthGetter();
                            result = result.Replace(format, getter.Get(format, currentTime)); 
                            break;
                        }
                    case 'd':
                        {
                            DayGetter getter = new DayGetter();
                            result = result.Replace(format, getter.Get(format, currentTime));
                            break;
                        }
                    case 'h':
                        {
                            HourGetter getter = new HourGetter();
                            result = result.Replace(format, getter.Get(format, currentTime));
                            break;
                        }
                    case 'm':
                        {
                            MinuteGetter getter = new MinuteGetter();
                            result = result.Replace(format, getter.Get(format, currentTime));
                            break;
                        }
                    case 's':
                        {
                            SecondGetter getter = new SecondGetter();
                            result = result.Replace(format, getter.Get(format, currentTime)); 
                            break;
                        }
                }
            }
            Console.WriteLine(result);
        }
    }
}
