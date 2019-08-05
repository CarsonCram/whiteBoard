using System;

namespace reverseInts
{
    public class reverse
    {
        public static int Num( int a )
        {

            string numba = a.ToString();
            string backward = "";
            for (int i = 0; i < numba.Length; i++)
            {
                backward = numba[i] + backward;
            }
            try
            {
                return int.Parse(backward);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\treverseInts.reverse.Main()");
            Console.WriteLine($"\n\t{Num(65433)}");
        }
    }
}
