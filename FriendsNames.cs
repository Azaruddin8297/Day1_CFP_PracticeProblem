using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class FriendsNames
    {
        public static void display()
        {
            string[] Names = new string[]{ "Shafi", "Sameer", "Ameer", "Azar", "Mahaboob" };
            Console.WriteLine("Names of My Friends are :");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
