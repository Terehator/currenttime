﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatGetter formatGetter = new FormatGetter();
            formatGetter.Get();
            Console.WriteLine(formatGetter.Get());
        }
    }
}
