using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixInputer matrixInputer = new MatrixInputer();
            MatrixMultiplier matrixMultiplier = new MatrixMultiplier();
            double[,] matrix1 = matrixInputer.InputFromConsole();
            double[,] matrix2 = matrixInputer.InputFromConsole();
            double[,] result;
            while (!matrixMultiplier.TryMultiply(matrix1, matrix2, out result))
            {
                matrix1 = matrixInputer.InputFromConsole();
                matrix2 = matrixInputer.InputFromConsole();
            }
            MatrixOutputer matrixOutputer = new MatrixOutputer();
            matrixOutputer.OutputToConsole(result);
            Console.ReadKey();
        }
    }
}
