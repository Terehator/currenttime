using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class TextParser
    {
        private string RemoveIgnoredSymbols(string text)
        {
            string result = "";
            foreach (char symbol in text)
            {
                if (char.IsLetter(symbol) || symbol == ' ')
                    result = result.Insert(result.Length, symbol.ToString());
            }
            return result;
        }


        public string TextParse(string text)
        {
            List<string> stringList = new List<string>();
            string tempText = RemoveIgnoredSymbols(text);
            return tempText.ToLower();
        }
    }
}
