using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class Factorial
    {
        public static int Fact(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
