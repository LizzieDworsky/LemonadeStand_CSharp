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
            List<string> optionsStr = new List<string> { "yes", "no", "y", "n" };
            string yesNo = UserInterface.ValidateStringInput($"You currently have {numberLemons} lemons. Would you like to buy more? y/n", optionsStr);
            if (yesNo == "y" || yesNo == "yes")
            {
                Console.WriteLine(yesNo);
            }
            else
            {
                Console.WriteLine(yesNo);
            }
        }
    }
}
