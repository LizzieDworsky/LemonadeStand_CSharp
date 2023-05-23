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
        public static double sugarCost;
        public static double cupCost;
        public static double iceCost;

        public static void SetPrices()
        {
            lemonCost = rand.Next(15, 51) / 100.0;
            sugarCost = rand.Next(50, 76) / 100.0;
            cupCost = rand.Next(5, 13) / 100.0;
            iceCost = rand.Next(5, 8) / 100.0;
            DisplayPrices();
        }

        private static void DisplayPrices()
        {
            Console.WriteLine($"Today Lemons cost ${lemonCost} each.");
            Console.WriteLine($"Today Cups of Sugar cost ${sugarCost} each.");
            Console.WriteLine($"Today Cups cost ${cupCost} each.");
            Console.WriteLine($"Today Ice Cubes cost ${iceCost} each.");
        }
    }
}
