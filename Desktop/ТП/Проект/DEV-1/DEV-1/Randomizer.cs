using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Randomizer
    {
        public static void outputRandomOptions(string[] options, int numberOfNeededOptions)
        {
            ArrayList ArrayListOfOptions = new ArrayList(Parser.parseArrayToArrayList(options));
            string result = "";
            Random random = new Random();
            try
            {
                for (int i = 0; i < numberOfNeededOptions; i++)
                {
                    int randomIndex = random.Next(0, ArrayListOfOptions.Count);
                    if (i == 0)
                    {
                        result = result + ArrayListOfOptions[randomIndex].ToString();
                    }
                    else
                    {
                        result = result + " " + ArrayListOfOptions[randomIndex].ToString();
                    }
                    ArrayListOfOptions.RemoveAt(randomIndex);
                }
                Outputer.outputToConsole(result);
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                Outputer.outputToConsole("Too few arguments!!! You must input at least " + numberOfNeededOptions + " arguments.");
            }
        }
    }
}
