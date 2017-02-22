using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class FrequencyCalculator
    {
        private int NO_FOUND = -1;
        private int LENGTH_OF_SUBSTRING = 2;
        private int CalculateFrequency(string twoSymbols, string text)
        {
            int frequency = 0;
            int index;
            string tempText = string.Copy(text);
            do
            {
                index = tempText.IndexOf(twoSymbols);
                if (index != NO_FOUND)
                {
                    frequency++;
                    tempText = tempText.Remove(index, LENGTH_OF_SUBSTRING);
                }
            } while (index != NO_FOUND);
            return frequency;
        }


        public void CalculateFrequencies(string text)
        {
            Dictionary<string, int> symbolsFrequencies = new Dictionary<string, int>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                string substring = text.Substring(i, LENGTH_OF_SUBSTRING);
                if (substring.Contains(' ') || symbolsFrequencies.ContainsKey(substring))
                    continue;
                else
                {
                    symbolsFrequencies.Add(substring, CalculateFrequency(substring, text));
                    Console.WriteLine("Frequency of {0} is {1}", substring, symbolsFrequencies[substring]);
                }
            }
        }
    }
}
