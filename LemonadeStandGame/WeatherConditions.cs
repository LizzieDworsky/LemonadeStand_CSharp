using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class WeatherConditions
    {
        private static Random rand = new Random();

        public static int GetTemperature()
        {
            
            return rand.Next(60, 93);
        }

        public static string GetConditions()
        {
            List<string> conditions = new List<string>
            {
                "sunny",
                "cloudy",
                "windy",
                "sunny",
                "rainy",
                "stormy",
                "sunny"
            };
            int index = rand.Next(conditions.Count);
            return conditions[index];
        }
    }
}
