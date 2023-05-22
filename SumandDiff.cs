using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class SumandDiff
    {
        public static void Compute()
        {
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double difference = number1 - number2;

            double squareOfSum = Math.Pow(sum, 2);
            double squareOfDifference = Math.Pow(difference, 2);

            Console.WriteLine("Square of the sum: " + squareOfSum);
            Console.WriteLine("Square of the difference: " + squareOfDifference);
        }
   
    }
}
