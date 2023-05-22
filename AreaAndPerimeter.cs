using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class AreaAndPerimeter
    {
        public static void Circle()
        {
            Console.WriteLine("Enter the Diameter of the circle :");
            double Dia = Convert.ToDouble(Console.ReadLine());

            double Radius = Dia/2;
            double Perimeter = 2 * Radius * Math.PI;
            double Area = Math.PI * Math.Pow(Radius, 2);

            Console.WriteLine("Perimeter of the Circle is : {0} ", Perimeter);
            Console.WriteLine("Area of the Circle is : {0} ", Area);
        }
    }
}
