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
            trueFalse = new List<bool>{ true, false};
        }

        public bool PurchaseLemonade()
        {
            CustomerInterface.RandomizeCustomer(trueFalse);
            return trueFalse[rand.Next(trueFalse.Count)];
        }
        
    }
}
