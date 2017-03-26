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
    public class Parser
    {
        private string checkersCoordinatePattern = @"^\s*[abcdefgh]\s*[12345678]\s*$";
        private string[] allowedWordsForWhiteColor = { "white", "w" };
        private string[] allowedWordsForBlackColor = { "black", "b" };
        /// <summary>
        /// Parse color into 'b' or 'w'
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public char ParseColor(string input)
        {
            input = input.ToLower();
            if (allowedWordsForBlackColor.Contains(input))
                return 'b';
            else
                if (allowedWordsForWhiteColor.Contains(input))
                    return 'w';
                else
                    throw new FormatException("Wrong format of color");
        }

        public Coordinate ParseCheckerCoordinate(string input)
        {
            input = input.ToLower();
            if (Regex.IsMatch(input, checkersCoordinatePattern))
            {
                input = input.Trim();
                if ((input.First() - 96) % 2 == input.Last() % 2)
                    return new Coordinate(input.First() - 'a' + 1, input.Last() - '1' + 1);
                else
                    throw new FormatException("Only black fields are allowed");
            }
            else
                throw new FormatException("Wrong format of coordinate");
        }
    }
}
