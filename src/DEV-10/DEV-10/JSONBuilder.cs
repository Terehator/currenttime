using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class JSONBuilder
    {
        private string TabulationMaker(int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
                result = string.Concat(result, ' ');
            return result;
        }
        public string PropertyToLine(string propertyName, object value, int tabCounter, bool last)
        {
            string result = TabulationMaker(tabCounter);
            result = string.Concat(result, "\"", propertyName, "\" : ");
            if (value.GetType().Equals(typeof(string)))
                result = string.Concat(result, "\"", value, "\"");
            else
                result = string.Concat(result, value);
            if (!last)
                result = string.Concat(result, ",");
            return result;
        }
        public string EnumToLine(string enumName, int tabCounter)
        {
            string result = TabulationMaker(tabCounter);
            return string.Concat(result, "\"", enumName, "\" : ", "[");
        }
        public string StartObjectToLine(int tabCounter)
        {
            return string.Concat(TabulationMaker(tabCounter), "{");
        }
        public string FinishObjectToLine(int tabCounter, bool isLast)
        {
            if (isLast)
                return string.Concat(TabulationMaker(tabCounter), "}");
            else
                return string.Concat(TabulationMaker(tabCounter), "},");
        }
    }
}
