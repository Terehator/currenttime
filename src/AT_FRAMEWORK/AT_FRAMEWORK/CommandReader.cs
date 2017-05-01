using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK
{
    /// <summary>
    /// Read commands
    /// </summary>
    class CommandReader
    {
        string filename;
        StreamReader reader;

        public CommandReader(string filename)
        {
            this.filename = filename;
            reader = new StreamReader(filename);
        }

        /// <summary>
        /// Return next command text
        /// </summary>
        /// <returns></returns>
        public string ReadNextComandFromFile()
        {
            string result = reader.ReadLine();
            if (result == null) reader.Close();
            return result;
        }
    }
}
