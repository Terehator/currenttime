using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class FormatGetter
    {
        string allowedSymbols = "hmsfydM:";
        public LinkedList<string> Get()
        {
            string inputedLine = Console.ReadLine();
            LinkedList<string> result = new LinkedList<string>();
            string tempFormat = "";
            foreach (char symbol in inputedLine)
            {
                if (!allowedSymbols.Contains(symbol))
                {
                    result = null;
                    break;
                }
                else
                {
                    if (symbol.Equals(':') && !string.IsNullOrEmpty(tempFormat))
                    {
                        result.AddLast(tempFormat);
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
