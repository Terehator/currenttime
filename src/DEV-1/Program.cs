﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    //Main class
    class Program
    {
        const int numberOfNeededOptions = 3;
        static void Main(string[] args)
        {
            Randomizer.outputRandomOptions(args, numberOfNeededOptions); //Output to console needed number of random options from args
        }
    }
}
