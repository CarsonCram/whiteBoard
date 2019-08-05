using System;

namespace switchVars
{
    public class Program
    {
        public static string vars(int a, int b)
        {
            if (a == b) { Console.WriteLine($"{a} = {a}, {b} = {b}"); }
            else 
            {
                b = b + a;
                a = b - a;
                b = b - a;
            }
            return $"{a}, {b}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tswitchVars.Program.Main()");
            vars(-3303, 200);
        }
    }
}
