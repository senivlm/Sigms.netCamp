using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        
        int[,] matrix;
        public Matrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
                throw new ArgumentException();

            matrix = new int[rows, cols];

        }
        public void InitMatrixDiagonal(int n) 
        {
            int number = 0;
            for (int line = 0; line < n; line++)
            {
                if (line % 2 == 0) 
                {
                    int i1 = line;
                    int j1 = 0;
                    for (int i = 0; i < line; i++)
                    {
                        matrix[i1, j1] = number++;
                        i1--;
                        j1++;
                    }
                
                }
                else 
                {
                    int i1 = 0;
                    int j1 = line;
                    for (int i = 0; i < line; i++)
                    {
                        matrix[i1, j1] = number++;
                        i1++;
                        j1--;
                    }
                }

            }
        
        }
        public void Show()
        {
             
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
           
        }
    }
}
