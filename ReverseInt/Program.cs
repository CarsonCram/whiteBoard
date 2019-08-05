using System;

namespace ReverseInt
{
    public class GetReverse
    {
        public static int ReverseThatInt(int a)
        {
            a = Math.Abs(a);
            int revNum = 0;
            while (a != 0)
            {
                revNum = revNum * 10 + a % 10;
                a = a / 10;
            }
            return revNum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tReverseInt.GetReverse.Main()");
            Console.WriteLine($"\n\t{ReverseThatInt(-543)}");
        }
    }
}
