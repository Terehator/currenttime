using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class FormatGetter
    {
        string allowedSymbols = "hmsydM:";
        public List<string> Get()
        {
            string inputedLine = Console.ReadLine();
            List<string> result = new List<string>();
            string tempFormat = string.Empty;
            foreach (char symbol in inputedLine)
            {
                if (!allowedSymbols.Contains(symbol))
                {
                    result = null;
                    break;
                }
                else
                {
                    if (((inputedLine.Last() == symbol) || (symbol == ':')) && !string.IsNullOrEmpty(tempFormat))
                    {
                        result.Add(tempFormat);
                        tempFormat = string.Empty;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(tempFormat))
                        {
                            tempFormat += symbol;
                        }
                        else
                        {
                            if (tempFormat[0] == symbol)
                            {
                                tempFormat += symbol;
                            }
                            else
                            {
                                result = null;
                                break;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
