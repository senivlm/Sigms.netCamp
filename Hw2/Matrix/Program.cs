using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           var matrix = new Matrix(5, 5);
            matrix.InitMatrixDiagonal(5);
            matrix.Show();




        }
        static void IntitShufle()
        {
            int[] arr = new int[10];
            var random = new Random();
            arr[0] = random.Next(1, arr.Length + 1);
            for (int i = 1; i < arr.Length; i++)
            {
                var temp = random.Next(1, arr.Length + 1);

                for (int j = i - 1; j >= 0; j--)
                    if (arr[j] == temp)
                    {
                        j = i;
                        temp = random.Next(1, arr.Length + 1);
                    }
                arr[i] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
