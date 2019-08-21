using System;

namespace DistinctCount
{
    class Program
    {
        static int distinct(int[] y)
        {
            Array.Sort(y);
            int count = 0;
            for (int i = 0; i < y.Length; i++)
            {
                while (i + 1 < y.Length && y[i] == y[i + 1])
                {
                    i++;
                }
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("DistinctCount.Program.Main()");

            int[] arr2 = { 6, 7, 8, 9, 6 };
            int[] arr = { 3, 5, 6, 6, 6, 8, 6 };
            int[] arr3 = { 4, 4, 4, 5 };

            Console.WriteLine(distinct(arr3));
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
                 
            }
        }
    }
}
