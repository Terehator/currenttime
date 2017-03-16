using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_12
{
    /// <summary>
    /// Parse color
    /// </summary>
    public class ColorParser
    {
        /// <summary>
        /// Parse color into 'b' or 'w'
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public char Parse(string input)
        {
            input = input.ToLower();
            if (string.Equals(input, "black") || string.Equals(input, "b"))
                return 'b';
            else
                if (string.Equals(input, "white") || string.Equals(input, "w"))
                    return 'w';
                else
                    throw new FormatException("Wrong format of color");
        }
    }
}
