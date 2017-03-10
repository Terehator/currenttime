using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEV_10
{
    /// <summary>
    /// Read config file
    /// </summary>
    class ConfigReader
    {
        /// <summary>
        /// Get filepathes
        /// </summary>
        /// <param name="configFilepath"></param>
        /// <param name="parser"></param>
        /// <param name="inputFilepath"></param>
        /// <param name="outputFilepath"></param>
        public void getFilepathes(string configFilepath, JSONParser parser, ref string inputFilepath, ref string outputFilepath)
        {
            string inputParamName = "input";
            string outputParamName = "output";
            using (StreamReader reader = new StreamReader(configFilepath))
            {
                string tempLine = reader.ReadLine();
                while (!parser.IsObjectStart(tempLine) && !reader.EndOfStream)
                    tempLine = reader.ReadLine();
                if (reader.EndOfStream)
                    throw new FormatException("No objects in config");
                tempLine = reader.ReadLine();
                bool inputReaded = false;
                bool outputReaded = false;
                while (!(inputReaded && outputReaded) && !parser.IsObjectFinish(tempLine) && !reader.EndOfStream)
                {
                    if (parser.IsCurrentParametr(tempLine, inputParamName))
                    {
                        inputFilepath = parser.GetValueByParametr(tempLine, inputParamName);
                        inputReaded = true;
                    }
                    else if (parser.IsCurrentParametr(tempLine, outputParamName))
                    {
                        outputFilepath = parser.GetValueByParametr(tempLine, outputParamName);
                        outputReaded = true;
                    }
                    tempLine = reader.ReadLine();
                }
                if (!inputReaded)
                    throw new FormatException("No input path");
                if (!outputReaded)
                    throw new FormatException("No output path");
            }
        }
    }
}
