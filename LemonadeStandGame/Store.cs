using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class Store
    {
        private static Random rand = new Random();
        public static double lemonCost;

        public static void SetPrices()
        {
            lemonCost = rand.Next(15, 76) / 100.0;
            DisplayPrices();
        }

        private static void DisplayPrices()
        {
            Console.WriteLine($"Today Lemons cost ${lemonCost} each.");
        }
    }
}
