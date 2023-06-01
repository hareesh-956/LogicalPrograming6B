using System;
using System.Diagnostics;
using static LogicalPrograming6.Coupon;

namespace LogicalPrograming6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Revers.ReverseNumber();
            Console.Write("Enter the number of distinct coupon numbers: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int totalRandomNumbersNeeded = CouponNumberSimulator.GenerateDistinctCouponNumbers(N);
            Console.WriteLine($"Total random numbers needed to have all distinct numbers: {totalRandomNumbersNeeded}");

            Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Press Enter to start the stopwatch");
            Console.ReadLine();
            stopwatch.Start();
            Console.WriteLine("Press Enter to stop the stopwatch");
            Console.ReadLine();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Elapsed Time: " + elapsedTime);



        }
    }
}