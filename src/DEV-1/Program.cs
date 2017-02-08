using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        const int numberOfNeededOptions = 3;
        static void Main(string[] args)
        {
            Randomizer.outputRandomOptions(args, numberOfNeededOptions);
        }
    }
}
