using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class Date
    {
        public static void Display()
        {
            Console.WriteLine("Enter a year :");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Month[1-12] :");
            int Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a day[1-31] :");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime currentDate = new DateTime(year,Month,day);
            DateTime nextDate = currentDate.AddDays(1);

            Console.WriteLine("The next date is [yyyy-mm-dd]: " + nextDate.ToString("yyyy-M-d"));
        }
    }
}
