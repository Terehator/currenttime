using AT_FRAMEWORK.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.CommandBuilders
{
    /// <summary>
    /// Create openComand
    /// </summary>
    class OpenComandCreator : ComandCreator
    {
        string comandPattern = @"^\s*open\s*";
        string argumentPattern = string.Concat('"', ".*?", '"');
        int argCount = 2;

        public OpenComandCreator(ComandCreator newSuccessor)
            : base(newSuccessor)
        {
        }

        /// <summary>
        /// Return comand
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public override IComand GetCommand(string line)
        {
            if (Regex.IsMatch(line, comandPattern))
            {
                line = Regex.Replace(line, comandPattern, string.Empty);
                MatchCollection arguments = Regex.Matches(line, argumentPattern);
                if (arguments.Count != argCount)
                    throw new ArgumentException("Wrong count of arguments");
                else
                {
                    string url = arguments[0].Value.Replace('"'.ToString() , string.Empty);
                    int timeout = 0;
                    if (!int.TryParse(arguments[1].Value.Replace('"'.ToString(), string.Empty), out timeout))
                        throw new ArgumentException("Wrong format of second argument");
                    else
                        return new OpenComand(url, timeout);
                }
            }
            if (successor == null)
                throw new ArgumentException("No such command");
            else
                return successor.GetCommand(line);
        }

    }
}
