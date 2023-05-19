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
        private static int predictionTemp;
        public static string weatherCond;
        public static int actualTemp;

        private static int GetTemperature(int tempFloor, int tempCeiling)
        {
            
            return rand.Next(tempFloor, tempCeiling);
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

        public static string Forecast(string tomorrow)
        {
            predictionTemp = GetTemperature(65, 87);
            weatherCond = GetConditions();
            return $"{tomorrow}'s conditions are forecasted to be {predictionTemp} and {weatherCond}";
        }

        public static string ActualWeather()
        {
            actualTemp = GetTemperature(predictionTemp-5, predictionTemp+5);
            return $"Today's weather is {actualTemp} and {weatherCond}";
        }

    }
}
