using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEV_10
{
    /// <summary>
    /// Read JSON file
    /// </summary>
    class JSONParser
    {
        public bool IsObjectStart(string line)
        {
            string startPattern = @"^\s*\{\s*$";
            return Regex.IsMatch(line, startPattern);
        }
        public bool IsObjectFinish(string line)
        {
            string finishPattern = @"^\s*\}\s*,?\s*$";
            return Regex.IsMatch(line, finishPattern);
        }
        public bool IsCurrentParametr(string line, string parametr)
        {
            string parametrBeginPattern = string.Concat(@"^\s*", '"', parametr, '"', @"\s*:\s*", '"', "?");
            string parametrFinishPattern = string.Concat('"', @"?\s*,?\s*$");
            return (Regex.IsMatch(line, parametrFinishPattern) &&
                    Regex.IsMatch(line, parametrBeginPattern));
        }
        public bool IsCurrentEnum(string line, string enumName)
        {
            string enumPattern = string.Concat(@"^\s*", '"', enumName, '"', @"\s*:\s*\[\s*$");
            return (Regex.IsMatch(line, enumPattern));
        }
        public bool IsEndOfEnum(string line)
        {
            string endOfEnumPattern = @"^\s*\]\s*,?\s*$";
            return (Regex.IsMatch(line, endOfEnumPattern));
        }
        public string GetValueByParametr(string line, string parametr)
        {
            string parametrBeginPattern = string.Concat(@"^\s*", '"', parametr, '"', @"\s*:\s*", '"', "?");
            string parametrFinishPattern = string.Concat('"', @"?\s*,?\s*$");
            string result = Regex.Replace(line, parametrBeginPattern, string.Empty);
            result = Regex.Replace(result, parametrFinishPattern, string.Empty);
            return result;
        }
    }
}
