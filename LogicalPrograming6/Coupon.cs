using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming6
{
    internal class Coupon
    {
        public class CouponNumberSimulator
        {
            public static int GenerateDistinctCouponNumbers(int N)
            {
                Random random = new Random();
                List<int> distinctCoupons = new List<int>();
                int randomNumbersGenerated = 0;

                while (distinctCoupons.Count < N)
                {
                    int randomNumber = random.Next(1, N + 1);
                    randomNumbersGenerated++;

                    if (!distinctCoupons.Contains(randomNumber))
                    {
                        distinctCoupons.Add(randomNumber);
                        Console.WriteLine($"Generated distinct coupon number: {randomNumber}");
                    }
                }

                return randomNumbersGenerated;
            }
        }

        
            
        
    }
}