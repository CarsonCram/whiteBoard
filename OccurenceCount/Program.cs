using System;

namespace OccurenceCount
{
    class Occurence
    {
        public static int Count(char letter, string input)
        {
            int count = 0;
            input.ToCharArray();

            foreach(char i in input)
            {
                if (i == letter)
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("OccurenceCount.Occurence.Main()");

            Console.WriteLine(Count('h', "hi, my nme is Johnson"));
        }
    }
}
