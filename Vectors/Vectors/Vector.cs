using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        int[] arr;


        public int this[int index]
        {
            get
            { 
                if(index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set 
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        public Vector() { }
     
        public void RandomInitialization(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
        }

        public void InitShufle()
        {
            Random random = new Random();
            int x;
            for (int i = 0; i < arr.Length; i++)
            {
                x = random.Next(1, arr.Length+1 );
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == x)
                    {
                        x = random.Next(1, arr.Length + 1);
                        j = -1;
                    }
                }
                arr[i] = x;
            }
        }

        public Pair[] CalculateFreq()
        {
            
            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pairs[i] = new Pair(0,0);

            }
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if(arr[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = arr[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }
        public void InitPolindrom()
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                arr[^(i + 1)] = i;
                arr[i] = arr[^(i + 1)];
            }
            if (arr.Length % 2 == 1)
                arr[arr.Length / 2] = arr[arr.Length / 2-1] + 1;

        }
        public bool CheckPolindrom() 
        {
            
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[^(i+1)])
                    return false;
            }
            return true;
        }
        public void ReverseMy() 
        {
            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[^(i + 1)];
                arr[^(i + 1)] = temp;
            }

        }
        public void Reverse()
        {
            arr=arr.Reverse().ToArray();
        }
        public string FindLongerSameFigure() 
        {
            string result=string.Empty;
            int longer = 0;
            int figure = 0;
            int count=1;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                    count++;
                else
                    count = 1;
                if (count > longer)
                {
                    longer = count;
                    figure = arr[i];
                    result = figure+" "+count;
                }
            }
            return result;
        }
    }

}
