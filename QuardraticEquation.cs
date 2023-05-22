using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class QuardraticEquation
    {
        public static void Equation()
        {
            Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c):");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Roots are real and different.");
                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Roots are real and equal.");
                Console.WriteLine("Root: " + root);
            }
            else
            {
                Console.WriteLine("Roots are complex and imaginary.");
            }
        }
    }
}
