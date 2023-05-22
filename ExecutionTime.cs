using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticesProblems
{
    public class ExecutionTime
    {
       public static void call()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine(timeSpan);
        }
    }
}
