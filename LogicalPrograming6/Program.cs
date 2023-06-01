using System;
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



        }
    }
}