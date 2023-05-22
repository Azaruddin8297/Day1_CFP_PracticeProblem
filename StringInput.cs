using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class StringInput
    {
        public static void Display()
        {
            Console.WriteLine("Enter a Number :");
            string Number = Console.ReadLine();
            int Num = Convert.ToInt32(Number);

            int result = Num * 10;
            string Value = result.ToString();
            Console.WriteLine("10 times of Enterd value is :"+Value);
        }
    }
}
