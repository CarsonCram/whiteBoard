using System;

namespace toCamelCase
{
    public class Program
    {
        public static string toCamel(string input)
        {
            string final = "";
            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                char nextChar = input[i];
                if (nextChar == ' ')
                {
                    nextChar = char.ToUpper(input[++i]);
                }
                else if (char.IsPunctuation(nextChar))
                {
                    i++;
                    nextChar = input[++i];
                }
                final += nextChar;
            }
            return final;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\ttoCamelCase.Program.Main()");
            Console.WriteLine(toCamel("\n\ta wonderful life"));
            Console.WriteLine(toCamel("\n\twhats up brah"));
            Console.WriteLine(toCamel("\n\tWHAT IN THE FUCK IS UP DUDE"));
        }
    }
}
