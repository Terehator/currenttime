﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Randomizer
    {
        private int numberOfNeededOptions;
        public Randomizer(int numberOfNeededOptions)
        {
            this.numberOfNeededOptions = numberOfNeededOptions;
        }
        public void outputRandomOptions(string[] options)
        {
            ArrayList arrayListOfOptions = new ArrayList(options);
            string result = "";
            Random random = new Random();
            if (arrayListOfOptions.Count >= numberOfNeededOptions)
            {
                for (int i = 0; i < numberOfNeededOptions; i++)
                {
                    int randomIndex = random.Next(0, arrayListOfOptions.Count);
                    if (i == 0)
                    {
                        result = result + arrayListOfOptions[randomIndex].ToString();
                    }
                    else
                    {
                        result = result + " " + arrayListOfOptions[randomIndex].ToString();
                    }
                    arrayListOfOptions.RemoveAt(randomIndex);
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Too few arguments!!! You must input at least " + numberOfNeededOptions + " arguments.");
            }
        }
    }
}
