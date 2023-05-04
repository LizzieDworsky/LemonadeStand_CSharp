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
        private static string predictionCond;

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

        public static string Forecast()
        {
            predictionTemp = GetTemperature(65, 87);
            predictionCond = GetConditions();
            return $"Tomorrow's conditions are forecasted to be {predictionTemp} and {predictionCond}";
        }

        public static string ActualWeather()
        {
            int actualTemp = GetTemperature(predictionTemp-5, predictionTemp+5);
            return $"Today's weather is {actualTemp} and {predictionCond}";
        }

    }
}
