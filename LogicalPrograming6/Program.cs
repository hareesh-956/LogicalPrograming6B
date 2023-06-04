﻿using System;
using System.Diagnostics;
using static LogicalPrograming6.Coupon;

namespace LogicalPrograming6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Revers.ReverseNumber();
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
            Console.WriteLine("Elapsed Time: " + elapsedTime);*/

            // Console.WriteLine("Enter the amount of change required:");
            // int change = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(">>>\tYou selected Calculate Monthly Payment");
            Console.WriteLine("Enter the (Y) years to pay off: ");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the (P) principal loan amount: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the (R) percent interest: ");
            int R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Monthly Payment AS PER THE GIVEN FORMULA is:" + MonthlyPayment.CalculateMonthlyPayment(P, Y, R));
            // Implement Calculate Monthly Payment logic here
            Console.WriteLine();

            Console.WriteLine(">>>\tYou selected Day of Week");
            /*int day = 0;
            int month = 0;
            int year = 0;*/
            Console.WriteLine("Enter the date: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month (in Number): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int dayOfWeek = DayOfWeek.DayWeek(day, month, year);
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string dayName = days[dayOfWeek]; // dayOfWeek is the index into the array

            Console.WriteLine("The day of the week on the given date (" + day + "/" + month + "/" + year + ") is: " + dayOfWeek + " which is " + dayName + ".");
            // Implement Day of Week logic here
            Console.WriteLine();



        }
    }
}