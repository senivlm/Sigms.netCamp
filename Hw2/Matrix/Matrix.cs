using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public int this[int i, int j]
        {
            get => matrix[i, j];
            set
            {
                matrix[i, j] = value;
            }
        }

        int[,] matrix;
        public Matrix() : this(5, 5)
        {

        }
        public Matrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
                throw new ArgumentException();

            matrix = new int[rows, cols];

        }
        public void InitMatrixDiagonal()
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
                throw new ArgumentException("matrix is not square");
            int matrixSquare = matrix.Length;
            int matrixLenth = matrix.GetLength(0);
            int number = 1;
            int numberForMirorReflection = matrixSquare;
            int coeficientForMirorReflection;
            int i1;
            int j1;
            int i2;
            int j2;
            for (int line = 0; line < matrixLenth; line++)
            {
                coeficientForMirorReflection = matrixLenth - 1 - line;
                if (line % 2 != 0)
                {
                    i1 = 0;
                    j1 = line;
                    for (int i = 0; i <= line; i++)
                    {
                        matrix[i1, j1] = number++;
                        if (matrixLenth != line)
                        {
                            i2 = j1 + coeficientForMirorReflection;
                            j2 = i1 + coeficientForMirorReflection;
                            matrix[i2, j2] = numberForMirorReflection--;
                        }
                        i1++;
                        j1--;
                    }
                }
                else
                {
                    i1 = line;
                    j1 = 0;
                    for (int i = 0; i <= line; i++)
                    {
                        matrix[i1, j1] = number++;
                        if (matrixLenth != line)
                        {
                            i2 = j1 + coeficientForMirorReflection;
                            j2 = i1 + coeficientForMirorReflection;
                            matrix[i2, j2] = numberForMirorReflection--;
                        }
                        i1--;
                        j1++;
                    }
                }
            }
        }

        enum Direction
        {
            Top, Down
        }
        public void InitMatrixDiagonalByEnum()
        {
            Direction direction;
            if (matrix.GetLength(0) != matrix.GetLength(1))
                throw new ArgumentException("matrix is not square");
            int matrixSquare = matrix.Length;
            int matrixLenth = matrix.GetLength(0);
            int number = 1;
            int numberForMirorReflection = matrixSquare;
            int coeficientForMirorReflection;
            int i1;
            int j1;
            int i2;
            int j2;
            for (int line = 0; line < matrixLenth; line++)
            {
                coeficientForMirorReflection = matrixLenth - 1 - line;
                if (line % 2 != 0)
                    direction = Direction.Top;
                else 
                    direction = Direction.Down;

                if (direction == Direction.Top)
                {
                    i1 = 0;
                    j1 = line;
                    for (int i = 0; i <= line; i++)
                    {
                        matrix[i1, j1] = number++;
                        if (matrixLenth != line)
                        {
                            i2 = j1 + coeficientForMirorReflection;
                            j2 = i1 + coeficientForMirorReflection;
                            matrix[i2, j2] = numberForMirorReflection--;
                        }
                        i1++;
                        j1--;
                    }
                }
                if(direction==Direction.Down)
                {
                    i1 = line;
                    j1 = 0;
                    for (int i = 0; i <= line; i++)
                    {
                        matrix[i1, j1] = number++;
                        if (matrixLenth != line)
                        {
                            i2 = j1 + coeficientForMirorReflection;
                            j2 = i1 + coeficientForMirorReflection;
                            matrix[i2, j2] = numberForMirorReflection--;
                        }
                        i1--;
                        j1++;
                    }
                }
            }
        }
        public override string ToString()
        {
            string matrixResult = string.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixResult += $"\t{matrix[i, j]}";
                }
                matrixResult += "\n";
            }
            return matrixResult;
        }
        public void InitVerticalSnake()
        {
            for (int j = 0, number = 1; j < matrix.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++, number++)
                    {
                        matrix[i, j] = number;
                    }
                }
                else
                {
                    for (int i = matrix.GetLength(0) - 1; i >= 0; i--, number++)
                    {
                        matrix[i, j] = number;
                    }
                }

            }

        }
        //private enum Direction
        //{
        //    Down,
        //    Right,
        //    Top,
        //    Left
        //}
        //void SpiralStep(ref int  x, ref int y, Direction direction)
        //{
        //    int result = direction switch
        //    {
        //        Direction.Down => x++,
        //        Direction.Right => y++,
        //        Direction.Top => x--,
        //        Direction.Left => y--
        //    };

        //}
        //public void InitSpiralSnake()
        //{
        //    int matrixLenthX = matrix.GetLength(0);
        //    int matrixLenthY = matrix.GetLength(1);


        //    for (int number = 1, x = 0, y = 0; number < matrix.Length+1; number++)
        //    {


        //    }
        //}
    }
}
