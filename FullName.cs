using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class FullName
    {
        public static void call()
        {
            Console.WriteLine("Please Enter Your Full Name :");
            string fullName = Console.ReadLine();

            string[] nameParts = fullName.Split(' ');
            int totalParts = nameParts.Length;
            Console.WriteLine("Total Parts Of a Name is :" + totalParts);

            string combinedName = string.Join(' ',nameParts);
            Console.WriteLine("Full Name is :" + combinedName);

        }
    }
}
