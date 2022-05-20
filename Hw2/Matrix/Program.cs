using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           var matrix = new Matrix(4,4);
            matrix.InitMatrixDiagonal();
            Console.WriteLine(matrix.ToString());

            matrix = new Matrix(3,4);
            matrix.InitVerticalSnake();
            Console.WriteLine(matrix.ToString());

            matrix = new Matrix(3, 4);
            matrix.InitSpiralSnake();
            Console.WriteLine(matrix.ToString());




        }
    }
}
