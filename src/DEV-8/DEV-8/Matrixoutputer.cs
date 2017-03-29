using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Output matrix
    /// </summary>
    class MatrixOutputer
    {
        /// <summary>
        /// Output to console
        /// </summary>
        /// <param name="matrix"></param>
        public void OutputToConsole(double[,] matrix)
        {
            Console.WriteLine("Matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
