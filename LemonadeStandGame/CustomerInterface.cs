using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class CustomerInterface
    {
        private static Random rand = new Random();
        

        public static void RandomizeCustomer(double lemonadePrice)
        {
            int customerProbability = 0;
            int number = rand.Next(2);
            if (number == 0)
            {
                customerProbability = rand.Next(10, 20);
            }
            else if (number == 1)
            {
                customerProbability = rand.Next(20, 30);
            }
            if (WeatherPrediction.weatherCond == "sunny")
            {
                customerProbability += rand.Next(15, 25);
            }
            Console.WriteLine(customerProbability);
        }

    }
}
