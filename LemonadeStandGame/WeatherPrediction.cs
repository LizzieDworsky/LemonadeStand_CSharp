using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class WeatherPrediction
    {
        private static Random rand = new Random();

        private static int GetTemperature()
        {
            
            return rand.Next(60, 93);
        }

        private static string GetConditions()
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

        public static string Forecast()
        {
            int temp = GetTemperature();
            string cond = GetConditions();
            return $"Tomorrow's conditions will be {temp} and {cond}";
        }

    }
}
