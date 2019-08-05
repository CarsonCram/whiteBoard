using System;

namespace RandomArrOfInts
{
    class RandomIntArray
    {
        public static int[] Num()
        {
            return Num(5);
        }

        public static int[] Num(int numElements, int maxValue)
        {
            int[] arr = new int[numElements];
            Random r = new Random();

            for (int i = 0; i < numElements; i++)
            {
                arr[i] = r.Next(maxValue);
            }
            return arr;
        }

        public static int GetMinValue(int[] myList)
        {
            int minListValue = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] < minListValue)
                {
                    minListValue = myList[i];
                }  
                return minListValue;
            }
        }

        public static int GetMaxValue(int[] myList)
        {
            int maxListValue = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] > maxListValue)
                {
                    maxListValue = myList[i];
                }
                return maxListValue;
            }
        }

        public static int[] ArraySort(int[] unsortedList)
        {
            int[] sortedList = new int[unsortedList.Length];

            for (int i = 0; i < unsortedList.Length; i++)
            {
                sortedList[i] = GetMaxValue(unsortedList);
            } 
            
            return sortedList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tRanomArrOfInts.Program.Main()");

            int size = 5;
            int maxValue = 100;

            int[] grades = Num(size, maxValue);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i} : {grades[i]}");
            }
        }
    }
}
