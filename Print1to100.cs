using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class Print1to100
    {
        public static void call(int num)
        {
            if (num <= 100)
            {
                Console.Write(num + ",");
                call(num + 1);
            }
           
        }
    }
}
