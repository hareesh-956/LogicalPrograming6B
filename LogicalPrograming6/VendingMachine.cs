﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming6
{
    internal class VendingMachine
    {
        internal class Vendingmachine
        {
            static int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };

            public static void Vmac(int amount)
            {
                //Console.WriteLine("Enter the amount of change required:");
                //int change = Convert.ToInt32(Console.ReadLine());
                CalculateChange(amount);
            }

            public static void CalculateChange(int change)
            {
                List<int> result = new List<int>();
                int remaining = change;

                for (int i = 0; i < notes.Length; i++)
                {
                    while (remaining >= notes[i])
                    {
                        remaining -= notes[i];
                        result.Add(notes[i]);
                    }
                }

                Console.WriteLine($"Minimum number of notes required: {result.Count}");

                Console.WriteLine("The notes are:");
                foreach (int note in result)
                {
                    //Console.WriteLine("₹ "+note);
                    Console.WriteLine("INR " + note);
                }
            }

        }
    }
}