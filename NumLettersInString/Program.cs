using System;
using System.Linq;

namespace NumLettersInString
{
    public class Program
    {
        public static int NumLetters(string sentence)
        {
            int count = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                    count++;
            }
            return count;
        } 
        static public void Main(String[] args)
        {
            Console.WriteLine(NumLetters("Hola"));
        }
    }
}
