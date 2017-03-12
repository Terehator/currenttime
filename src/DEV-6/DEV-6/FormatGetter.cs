using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class FormatGetter
    {
        string allowedSymbols = "hmsydM";
        public List<string> Get(string inputedLine)
        {
            List<string> result = new List<string>();
            string tempFormat = string.Empty;
            foreach (char symbol in inputedLine)
            {
                if (allowedSymbols.Contains(symbol))
                {
                    if (string.IsNullOrEmpty(tempFormat) || tempFormat.Contains(symbol))
                        tempFormat = string.Concat(tempFormat, symbol);
                    else
                        throw new FormatException("Not allowed format");
                }
                else
                {
                    if (!string.IsNullOrEmpty(tempFormat))
                    {
                        result.Add(tempFormat);
                        tempFormat = string.Empty;
                    }
                }
            }
            if (!string.IsNullOrEmpty(tempFormat))
                result.Add(tempFormat);
            return result;
        }
    }
}
