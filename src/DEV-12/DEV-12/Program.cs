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
                Parser parser = new Parser();
                Console.WriteLine("Input color of checker(black or white)");
                char color = parser.ParseColor(Console.ReadLine());
                Console.WriteLine("Input start coordinate");
                Coordinate start = parser.ParseCheckerCoordinate(Console.ReadLine());
                Console.WriteLine("Input finish coordinate");
                Coordinate finish = parser.ParseCheckerCoordinate(Console.ReadLine());
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
