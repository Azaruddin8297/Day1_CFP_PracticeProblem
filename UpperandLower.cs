using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class UpperandLower
    {
        public static void Display()
        {
            Console.WriteLine("Enter your Fav Place Name :");
            string Name = Console.ReadLine();

            string UpperName = Name.ToUpper();
            Console.WriteLine("UpperCase :" + UpperName);

            string LowerName = Name.ToLower();
            Console.WriteLine("LowerCase :" + LowerName);
        }
    }
}
