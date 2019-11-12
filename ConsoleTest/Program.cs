using PugachAlgorithms;
using System;
using System.Diagnostics;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 1000;
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next() % 500;

            Timing timing = new Timing();
            Stopwatch stpWatch = new Stopwatch();

            timing.StartTime();
            stpWatch.Start();
            for(int i = 0; i < 500000; i++)
            {
                rnd.Next();
            }

            stpWatch.Stop();
            timing.StopTime();

            Console.WriteLine("StopWatch: " + stpWatch.Elapsed.ToString());
            Console.WriteLine("Timing: " + timing.Result().ToString());
            Console.ReadLine();
        }
    }
}
