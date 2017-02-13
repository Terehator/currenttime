using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Counter
    {
        public float count(List<float> numbers, ArrayList signes)
        {
            try
            {
                while (signes.IndexOf('*') != -1)
                {
                    int index = signes.IndexOf('*');
                    numbers[index] = numbers[index] * numbers[index + 1];
                    numbers.RemoveAt(index + 1);
                    signes.RemoveAt(index);
                }
                while (signes.IndexOf('/') != -1)
                {
                    int index = signes.IndexOf('/');
                    numbers[index] = numbers[index] / numbers[index + 1];
                    numbers.RemoveAt(index + 1);
                    signes.RemoveAt(index);
                }
                while (signes.IndexOf('+') != -1)
                {
                    int index = signes.IndexOf('+');
                    numbers[index] = numbers[index] + numbers[index + 1];
                    numbers.RemoveAt(index + 1);
                    signes.RemoveAt(index);
                }
                while (signes.IndexOf('-') != -1)
                {
                    int index = signes.IndexOf('-');
                    numbers[index] = numbers[index] - numbers[index + 1];
                    numbers.RemoveAt(index + 1);
                    signes.RemoveAt(index);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numbers are too big");
                throw;
            }
            return numbers[0];
        }
    }
}
