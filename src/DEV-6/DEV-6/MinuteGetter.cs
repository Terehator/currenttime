using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class MinuteGetter
    {
        public string Get(string format, DateTime currentDateTime)
        {
            switch (format.Length)
            {
                case 1:
                    {
                        return currentDateTime.Minute.ToString();
                    }
                case 2:
                    {
                        int rez = currentDateTime.Minute;
                        if (rez < 10)
                            return "0" + rez.ToString();
                        else
                            return rez.ToString();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
