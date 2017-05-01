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
    /// Create CheckLinkPresentByName
    /// </summary>
    class CheckLinkPresentByNameComandCreator : ComandCreator
    {
        string comandPattern = @"^\s*checkLinkPresentByName\s*";
        string argumentPattern = string.Concat('"', ".*?", '"');
        int argCount = 1;

        public CheckLinkPresentByNameComandCreator(ComandCreator newSuccessor)
            : base(newSuccessor)
        {
        }

        /// <summary>
        /// Return command
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
                    return new CheckLinkByPresentNameComand(arguments[0].Value.Replace('"'.ToString(), string.Empty));
                }
            }
            if (successor == null)
                throw new ArgumentException("No such command");
            else
                return successor.GetCommand(line);
        }
    }
}
