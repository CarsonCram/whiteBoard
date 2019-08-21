using System;

namespace FindPrimeNumber
{
    public class Program
    {
        public static bool findPrime(int y)
        {
            if (y < 2) return false;

            for (int i = 2; i < y; i++)
            {
                if (y % i == 0) return false;
            }
            return true;
        }    
          
        static void Main(string[] args)
        {
            Console.WriteLine("FindPrimeNumber.Program.Main()");
            Console.WriteLine(findPrime(11));
            Console.WriteLine(findPrime(10));
            Console.WriteLine(findPrime(13));
            Console.WriteLine(findPrime(113));
            Console.WriteLine(findPrime(2));
        }
    }
}
