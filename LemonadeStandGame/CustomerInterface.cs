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
        

        public static int RandomizeCustomer(double lemonadePrice, int currentTemp, string weatherCond)
        {
            int customerProbability = 0;
            int number = rand.Next(2);
            if (number == 0)
            {
                customerProbability = rand.Next(25, 35);
            }
            else if (number == 1)
            {
                customerProbability = rand.Next(35, 45);
            }
            if (weatherCond == "sunny")
            {
                customerProbability += 30;
            }
            else if (weatherCond == "cloudy" || weatherCond == "windy")
            {
                customerProbability += 15;
            }
            if (currentTemp < 70)
            {
                customerProbability -= rand.Next(5, 10);
            }
            else if (currentTemp < 80)
            {
                customerProbability += rand.Next(5, 10);
            }
            else
            {
                customerProbability += rand.Next(15, 20);
            }
            if (lemonadePrice < .35)
            {
                customerProbability += rand.Next(30, 40);
            }
            else if (lemonadePrice > 1)
            {
                customerProbability -= rand.Next(30, 40);
            }
            else
            {
                customerProbability += rand.Next(10, 20);
            }
            return customerProbability;
        }

    }
}
