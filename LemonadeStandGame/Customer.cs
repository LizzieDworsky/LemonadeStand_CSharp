using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal class Customer
    {
        private Random rand;
        private List<bool> trueFalse;

        public Customer()
        {
            rand = new Random();
            trueFalse = new List<bool>{ true, false };
        }

        public bool WillBuyLemonade(double lemonadePrice, int currentTemp, string weatherCond)
        {
            int customerProbability = CustomerInterface.RandomizeCustomer(lemonadePrice, currentTemp, weatherCond);
            if (customerProbability >= rand.Next(70, 80))
            {
                return true;
            }
            else if (customerProbability <= rand.Next(20, 30))
            {
                return false;
            }
            else
            {
                return trueFalse[rand.Next(trueFalse.Count)];
            }
        }
    }
}
