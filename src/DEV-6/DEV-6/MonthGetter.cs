using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class MonthGetter
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public string Get(string format, DateTime currentDateTime)
        {
            switch (format.Length)
            {
                case 1:
                    {
                        return currentDateTime.Month.ToString();
                    }
                case 2:
                    {
                        int rez = currentDateTime.Month;
                        if (rez < 10)
                            return "0" + rez.ToString();
                        else
                            return rez.ToString();
                    }
                case 3:
                    {
                        return months[currentDateTime.Year - 1].Substring(0, 3);
                    }
                case 4:
                    {
                        return months[currentDateTime.Year - 1];
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
