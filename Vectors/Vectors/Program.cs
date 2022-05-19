using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vector arr = new Vector(20);
            arr.RandomInitialization(1, 5);

            try
            {
                arr[0] = 999;
                Console.WriteLine(arr[21]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Pair[] pairs = arr.CalculateFreq();

            for (int i = 0; i < pairs.Length; i++)
            {
                Console.Write(pairs[i] + "\n");
            }
            Console.WriteLine();

            Console.WriteLine(pairs);
            arr.RandomInitialization();
            Console.WriteLine(arr);*/



            Pair pair1 = new Pair(2, 5);
            Pair pair2 = new Pair(2, 5);
            Pair pair3 = pair1;
            Console.WriteLine(pair1.Equals(pair2));
            Console.WriteLine(ReferenceEquals(pair1, pair2));
            Console.WriteLine(ReferenceEquals(pair1, pair3));
            Console.WriteLine(pair1 == pair3);
            Console.WriteLine(pair1 == pair2);
            Console.WriteLine(pair1.GetHashCode());
            Console.WriteLine(pair2.GetHashCode());
            Console.WriteLine(pair3.GetHashCode());
            Console.WriteLine(pair3.GetType());



        }
    }
}
