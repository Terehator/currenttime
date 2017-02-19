using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class WordSorter
    {
        private int LENGTH = 5;


        public void PrintWordsOfNeededLength(string text)
        {
            List<string> listOfWords = text.Split(' ').ToList();
            foreach (string word in listOfWords)
            {
                if (word.Length >= LENGTH)
                    Console.WriteLine(word);
            }
        }
    }
}
