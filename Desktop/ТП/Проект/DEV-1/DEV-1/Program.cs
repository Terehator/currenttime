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
        static void Main(string[] args) //Main class
        {
            Randomizer randomizer = new Randomizer(numberOfNeededOptions);
            randomizer.outputRandomOptions(args); //Output needed number of options into the console
        }
    }
}
