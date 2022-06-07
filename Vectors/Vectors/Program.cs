using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {//ваш номер 44. 
           // дотримуйтесь порядку 
            Vector arr = new Vector(12);
            arr.InitShufle();
            Console.WriteLine(arr);
            arr.Reverse();
            Console.WriteLine(arr);
            arr.ReverseMy();
            Console.WriteLine(arr);
            Console.WriteLine(arr.CheckPolindrom());
            int end = 2;
            int number = 1;
            for (int i = 0; i < 12;end++,number++)
            {
                for (int j = 0; j < end&&i<12; i++,j++)
                {
                    arr[i] = number;
                }
            }
            Console.WriteLine(arr); 
            Console.WriteLine(arr.FindLongerSameFigure());

        }
    }
}
