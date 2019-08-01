using System;

namespace CountCapitals
{
    public class UpperCase
    {
        public static int CountCapitals(string sentence)
        {
            int count = 0;

            foreach (char letter in sentence)
            {
                if (char.IsUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }

        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (char.IsUpper(sentence[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        public static void Main(string[] args)
        { 
            Console.WriteLine("CountCapitals.UpperCase.Main()");
        }
        
    }
}
