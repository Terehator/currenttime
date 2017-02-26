using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class DateTimeOutputer
    {
        public void Output(DateTime currentTime, List<string> formats)
        {
            string result = string.Empty;
            bool flagOfNull = false;
            if (formats != null)
            {
                foreach (string format in formats)
                {
                    switch (format[0])
                    {
                        case 'y':
                            {
                                YearGetter getter = new YearGetter();
                                if (getter != null)
                                    result += getter.Get(format, currentTime);
                                else
                                    flagOfNull = true;
                                break;
                            }
                        case 'M':
                            {
                                MonthGetter getter = new MonthGetter();
                                if (getter != null)
                                    result += getter.Get(format, currentTime);
                                else
                                    flagOfNull = true;
                                break;
                            }
                        case 'd':
                            {
                                DayGetter getter = new DayGetter();
                                if (getter != null)
                                    result += getter.Get(format, currentTime);
                                else
                                    flagOfNull = true;
                                break;
                            }
                        case 'h':
                            {
                                HourGetter getter = new HourGetter();
                                if (getter != null)
                                    result += getter.Get(format, currentTime);
                                else
                                    flagOfNull = true;
                                break;
                            }
                        case 'm':
                            {
                                MinuteGetter getter = new MinuteGetter();
                                if (getter != null)
                                    result += getter.Get(format, currentTime);
                                else
                                    flagOfNull = true;
                                break;
                            }
                        case 's':
                            {
                                SecondGetter getter = new SecondGetter();
                                if (getter != null)
                                    result += getter.Get(format, currentTime);
                                else
                                    flagOfNull = true;
                                break;
                            }
                    }
                    if (flagOfNull)
                    {
                        result = null;
                        break;
                    }
                    else
                        result += ":";
                }
            }
            else
            {
                result = null;
            }
            if (result == null)
                Console.WriteLine("Not allowed format");
            else
                Console.WriteLine(result);
        }
    }
}
