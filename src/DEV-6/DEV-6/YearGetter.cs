using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class YearGetter
    {
        public string Get(string format, DateTime currentDateTime)
        {
            switch (format.Length)
            {
                case 2:
                    {
                        return (currentDateTime.Year % 100).ToString();
                    }
                case 3:
                    {
                        return (currentDateTime.Year % 1000).ToString();
                    }
                case 4:
                    {
                        return currentDateTime.Year.ToString();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
