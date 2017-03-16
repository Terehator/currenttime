using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEV_12
{
    /// <summary>
    /// Parse coordinate
    /// </summary>
    public class CoordinateParser
    {
        public Tuple<int, int> Parse(string input)
        {
            input = input.ToLower();
            string coordinatePattern = @"^\s*[abcdefgh]\s*[12345678]\s*$";
            if (Regex.IsMatch(input, coordinatePattern))
            {
                input = input.Trim();
                if ((input.First() - 96) % 2 == input.Last() % 2)
                    return new Tuple<int, int>(input.First() - 96, input.Last() - 48);
                else
                    throw new FormatException("Only black fields are allowed");
            }
            else
                throw new FormatException("Wrong format of coordinate");
        }
    }
}
