using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Input matrix
    /// </summary>
    class MatrixInputer
    {
        /// <summary>
        /// Return parsed int
        /// </summary>
        /// <param name="messageBeforeInput"></param>
        /// <returns></returns>
        private int InputIntWhileUntillCorrect(string messageBeforeInput)
        {
            Console.WriteLine(messageBeforeInput);
            int rez;
            while (!int.TryParse(Console.ReadLine(), out rez) || (rez <= 0))
            {
                Console.WriteLine("Bad input!!!" + messageBeforeInput);
            }
            return rez;
        }
        /// <summary>
        /// Return parsed double
        /// </summary>
        /// <param name="messageBeforeInput"></param>
        /// <returns></returns>
        private double InputDoubleWhileUntillCorrect(string messageBeforeInput)
        {
            Console.WriteLine(messageBeforeInput);
            double rez = 0.0;
            while (!double.TryParse(Console.ReadLine(), out rez))
            {
                Console.WriteLine("Bad input!!!" + messageBeforeInput);
            }
            return rez;
        }
        /// <summary>
        /// Input matrix from console
        /// </summary>
        /// <returns></returns>
        public double[,] InputFromConsole()
        {
            int columns = InputIntWhileUntillCorrect("Input columns count");
            int rows = InputIntWhileUntillCorrect("Input rows count");
            double[,] result = new double[columns,rows];
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                {
                    string message = string.Concat("Input element ", i, ":", j);
                    result[i, j] = InputDoubleWhileUntillCorrect(message);
                }
            return result;
        }
    }
}
