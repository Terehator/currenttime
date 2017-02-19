using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// Main class
    /// Show functionality
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TextParser testParser = new TextParser();
            string text = testParser.TextParse(Console.ReadLine());
            FrequencyCalculator frequencyCalculator = new FrequencyCalculator();
            frequencyCalculator.CalculateFrequencies(text);
            Console.ReadKey();
            WordSorter wordSorter = new WordSorter();
            wordSorter.PrintWordsOfNeededLength(text);
        }
    }
}
