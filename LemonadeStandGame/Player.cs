using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal class Player
    {
        public double money;
        public int numberLemons;
        public int numberSugar;
        public int numberCups;
        public int numberIce;

        public Player()
        {
            money = 45;
            numberLemons = 0; 
            numberSugar = 0; 
            numberCups = 0;
            numberIce = 0;
        }

        public void BuyProduct()
        {
            List<char> yNOptions = new List<char> { 'y', 'n' };
            char yesNo = UserInterface.ValidateCharInput($"You currently have {numberLemons} lemons. Would you like to buy more? y/n", yNOptions);
            if (yesNo == 'y')
            {
                int number = UserInterface.ValidateIntInput("How many lemons would you like to buy?");
                double total = number * Store.lemonCost;
                if (total < money)
                {
                    Console.WriteLine(total);
                    Console.WriteLine(UserInterface.FormatDouble(total));
                }
            }
        }
    }
}
