using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class AverageofNumbers
    {
        public static void Avg()
        {
            Random random = new Random();
            int sum = 0;
            int[] number = new int[5];
            for(int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(10, 51);

                sum += number[i];

            }
            double avg = sum / number.Length;
            Console.WriteLine("Value Generated are :" + string.Join(", ", number) );
            Console.WriteLine("Average of Numbers are :" + avg);

        }
    }
}
