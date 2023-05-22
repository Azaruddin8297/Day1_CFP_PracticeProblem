using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class Divisibleby7
    {
        public static void call()
        {
            int startNumber = 2000;
            int endNumber = 3200;

            string result = "";

            for (int number = startNumber; number <= endNumber; number++)
            {
                if (number % 7 == 0 && number % 5 != 0)
                {
                    result += number.ToString() + ",";
                }
            }
            Console.WriteLine(result);
        }
    }
}
