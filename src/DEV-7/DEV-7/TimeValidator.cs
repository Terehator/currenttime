using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class TimeValidator
    {
        int HOUR_MAX = 23;
        int MINUTES_MAX = 60;
        int SECONDS_MAX = 60;
        int HOUR_MIN = 0;
        int MINUTES_MIN = 0;
        int SECONDS_MIN = 0;
        public bool Validate(Time time)
        {
            return (time.hours >= HOUR_MIN && time.hours <= HOUR_MAX &&
                    time.minutes >= MINUTES_MIN && time.minutes <= MINUTES_MAX &&
                    time.seconds >= SECONDS_MIN && time.seconds <= SECONDS_MAX);
        }
    }
}
