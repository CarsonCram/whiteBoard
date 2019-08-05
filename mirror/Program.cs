using System;

namespace mirror
{
    public class reverseString
    {
        public static string reverse(string forward)
        {

            string backward = "";
            for (int i = 0; i < forward.Length; i++)
            {
                backward = forward[i] + backward; 
            }
            return backward;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tmirror.reverseString.Main()");
            Console.WriteLine($"\n\t{reverse("carson")}");
        }
    }
}
