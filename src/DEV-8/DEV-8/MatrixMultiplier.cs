using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Multiply matrixes
    /// </summary>
    class MatrixMultiplier
    {
        /// <summary>
        /// Multiply matrixes
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryMultiply(double[,] matrix1, double[,] matrix2, out double[,] result)
        {
            if ((matrix1.GetLength(0) == matrix2.GetLength(1))
                && matrix1 != null
                && matrix2 != null)
            {
                int columns = matrix1.GetLength(1);
                int rows = matrix2.GetLength(0);
                int elements = matrix1.GetLength(0);
                Console.WriteLine(columns+" "+rows);
                result = new double[matrix1.GetLength(1), matrix2.GetLength(0)];
                try
                {
                    for (int i = 0; i < columns; i++)
                        for (int j = 0; j < rows; j++)
                        {
                            double sum = 0;
                            for (int k = 0; k < elements; k++)
                                 sum += matrix1[k, i] * matrix2[j, k];
                            result[i, j] = sum;
                        }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Too big numbers");
                    return false;
                }
                return true;
            }
            else
            {
                result = null;
                Console.WriteLine("Not acceptable sizes");
                return false;
            }
        }
    }
}
