using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class DateValidator
    {
        int YEAR_MIN = 0;
        int MONTH_MIN = 1;
        int MONTH_MAX = 12;
        int[] DAY_MAX = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int DAY_MIN = 1;
        public bool Validate(Date date)
        {
            bool allowed = false;
            if (date.year >= YEAR_MIN &&
                date.month >= MONTH_MIN && date.month <= MONTH_MAX &&
                date.day >= DAY_MIN)
            {
                if (date.month != 2)
                {
                    if (date.day <= DAY_MAX[date.month - 1])
                        allowed = true;
                }
                else
                {
                    if ((date.IsLeap() && date.day <= DAY_MAX[date.month] - 1) ||
                        (!date.IsLeap() && date.day <= DAY_MAX[date.month]))
                        allowed = true;
                }
            }
            return allowed;
        }
    }
}
