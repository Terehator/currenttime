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
        private void doOperation(List<float> numbers, ArrayList signes, char sign)
        {
            while (signes.IndexOf(sign) != -1)
            {
                int index = signes.IndexOf(sign);
                switch (sign)
                {
                    case '*':
                        numbers[index] = numbers[index] * numbers[index + 1];
                        break;
                    case '/':
                        numbers[index] = numbers[index] / numbers[index + 1];
                        break;
                    case '-':
                        numbers[index] = numbers[index] - numbers[index + 1];
                        break;
                    case '+':
                        numbers[index] = numbers[index] + numbers[index + 1];
                        break;
                }
                numbers.RemoveAt(index + 1);
                signes.RemoveAt(index);
            }
        }
        public float count(List<float> numbers, ArrayList signes)
        {
            try
            {
                doOperation(numbers, signes, '*');
                doOperation(numbers, signes, '/');
                doOperation(numbers, signes, '-');
                doOperation(numbers, signes, '+');
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
