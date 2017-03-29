using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Date
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public bool IsLeap()
        {
            if (year % 4 == 0)
                return true;
            else
                return false;
        }
    }
}
