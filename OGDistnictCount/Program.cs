using System;

namespace OGDistnictCount
{
    class Program
    {
        static int Count(int[] y)
        {
            int distinct = 0;
            
            for (int i = 0; i < y.Length; i++)
            {
                bool isNew = true;

                for (int j = 0; j < i; j++)
                {
                    if(y[i] == y[j])
                    {
                        isNew = false;
                    }
                }
                if (isNew)
                {
                    distinct++;
                }
            }
            return distinct;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tOGDistinctCount.Program.Main()");

            int[] arr = { 5, 4, 5, 6 };
            Console.WriteLine(Count(arr));
        }
    }
}