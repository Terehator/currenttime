using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEV_9
{
    /// <summary>
    /// Explore .ini file
    /// </summary>
    class IniFileExplorer
    {
        string path;
        public IniFileExplorer(string path)
        {
            this.path = path;
        }
        /// <summary>
        /// Get value at section and key
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValueBySectionAndKey(string section, string key)
        {
            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.Default))
            {
                string sectionPattern = string.Concat(@"^\[", section, @"\]$");
                string line = reader.ReadLine();
                while (!Regex.IsMatch(line, sectionPattern) && !reader.EndOfStream)
                {
                    line = reader.ReadLine();
                }
                if (!Regex.IsMatch(line, sectionPattern) && reader.EndOfStream)
                    throw new SectionNotFoundException(string.Concat("Can't find section ", section));
                else
                {
                    return GetValueByKeyInCurrentSection(section, key, reader);
                }
            }
        }
        /// <summary>
        /// Get value by key only in one section
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        private string GetValueByKeyInCurrentSection(string section, string key, StreamReader reader)
        {
            string keyPattern = string.Concat("^", key, "=");
            string sectionPattern = @"^\[.*\]$";
            string line = reader.ReadLine();
            while (!Regex.IsMatch(line, keyPattern)
                && !Regex.IsMatch(line, sectionPattern)
                && !reader.EndOfStream)
            {
                line = reader.ReadLine();
            }
            if (!Regex.IsMatch(line, keyPattern))
                throw new KeyNotFoundException(string.Concat("Can't find key ", key, " in section ", section));
            else
            {
                return Regex.Replace(line, keyPattern, string.Empty);
            }
        }
    }
}
