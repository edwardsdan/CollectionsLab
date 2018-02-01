using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CollectionsLab
{
    class Calculate
    {
        public static int ArrayLength = Program.CartPrice.ToArray().Length;

        public static void AverageCost()
        {
            double TotalCost = 0;
            foreach(double i in Program.CartPrice)
            {
                TotalCost += i;
            }
            Program.PrintCart();

            Console.WriteLine($"Your total is ${TotalCost} and the average item is ${Math.Round(TotalCost/ArrayLength, 3)}");
        }

        public static void LowestCost()
        {
            double Cheapest = (double)Program.CartPrice[0];
            int IndexOfCheapest = 0;
            for (int i = 0; i < ArrayLength; i++)
            {
                if (Cheapest > (double)Program.CartPrice[i])
                {
                    Cheapest = (double)Program.CartPrice[i];
                    IndexOfCheapest = i;
                }
            }
            Console.WriteLine($"The cheapest item was ${Program.CartPrice[IndexOfCheapest]}");
        }
        
        public static void HighestCost()
        {
            double Expensive = (double)Program.CartPrice[0];
            int IndexOfHighCost = 0;
            for (int i = 0; i < ArrayLength; i++)
            {
                if (Expensive < (double)Program.CartPrice[i])
                {
                    Expensive = (double)Program.CartPrice[i];
                    IndexOfHighCost = i;
                }
            }
            Console.WriteLine($"The most expensive item was ${Program.CartPrice[IndexOfHighCost]}");
        }
    }
}
