using System;
namespace MonthFromDay
{
    public class Program
    {
        public static int jd ( int month, int day )
        {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int dayCount = 0;

            for (int i = 0; i < month; i++)
            {
                dayCount += months[i];
            };

            day = dayCount + day; 
            
            return day;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MonthFromDate.Program.Main()");
            Console.WriteLine(jd(12,30));
        }
    }
}
