using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ColorParser colorParser = new ColorParser();
                Console.WriteLine("Input color of checker(black or white)");
                char color = colorParser.Parse(Console.ReadLine());
                CoordinateParser coorParser = new CoordinateParser();
                Console.WriteLine("Input start coordinate");
                Tuple<int, int> start = coorParser.Parse(Console.ReadLine());
                Console.WriteLine("Input finish coordinate");
                Tuple<int, int> finish = coorParser.Parse(Console.ReadLine());
                StepsCounter stepsCounter = new StepsCounter();
                Console.WriteLine(stepsCounter.Count(color, start, finish));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
