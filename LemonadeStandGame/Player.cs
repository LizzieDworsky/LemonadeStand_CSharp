using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal class Player
    {
        public string username;
        public double money;
        public int numberLemons;
        public int numberSugar;
        public int numberCups;
        public int numberIce;
        public double pricePerCup;
        public Dictionary<string, int> recipe;

        public Player(string name)
        {
            username = name;
            money = 45;
            numberLemons = 0; 
            numberSugar = 0; 
            numberCups = 0;
            numberIce = 0;
            pricePerCup = 0.25;
            recipe = new Dictionary<string, int> { { "Lemons", 0 }, {"Sugar", 0 }, {"Cups", 0 }, {"Ice", 0 } };
        }

        public void BuyProduct(string currentProduct, int productField, double storePrice)
        {
            List<char> yNOptions = new List<char> { 'y', 'n' };
            char yesNo = UserInterface.ValidateCharInput($"You currently have {productField} {currentProduct}. Would you like to buy more? y/n", yNOptions);
            if (yesNo == 'y')
            {
                bool tryAgain = true;
                while (tryAgain)
                {
                    int number = UserInterface.ValidateIntInput($"How many {currentProduct} would you like to buy?");
                    double total = number * storePrice;
                    if (total < money)
                    {
                        tryAgain = false;
                        money -= total;
                        productField += number;
                        Console.WriteLine($"You bought {number} {currentProduct} for {UserInterface.FormatDouble(total)}. You now have ${UserInterface.FormatDouble(money)} and {productField} {currentProduct}.");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, that would cost {UserInterface.FormatDouble(total)} and you only have {UserInterface.FormatDouble(money)}");
                    }
                }
            }
        }

        public void SetRecipe()
        {
            Console.WriteLine("Your current recipe for lemonade is:");
            foreach (KeyValuePair<string, int> kvp in recipe)
            {
                Console.WriteLine("{1} {0}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("Would you like to change your recipe?");
            List<char> yNOptions = new List<char> { 'y', 'n' };
            char yesNo = UserInterface.ValidateCharInput($"You currently are using {numberLemons} lemons. Would you like to adjust this? y/n", yNOptions);
            if (yesNo == 'y')
            {
                int number = UserInterface.ValidateIntInput("How many lemons would you like to use?");
                recipe["Lemons"] = number;
                Console.WriteLine("Your new recipe is:");
                foreach (KeyValuePair<string, int> kvp in recipe)
                {
                    Console.WriteLine("{1} {0}", kvp.Key, kvp.Value);
                }
            }
        }

        public void SetPrice()
        {
            List<char> yNOptions = new List<char> { 'y', 'n' };
            char yesNo = UserInterface.ValidateCharInput($"Your lemonade currently costs ${pricePerCup} per cup. Would you like to adjust your price? y/n", yNOptions);
            if (yesNo == 'y')
            {
                pricePerCup = UserInterface.ValidateDoubleInput("What price would you like to make each cup?");
                Console.WriteLine($"Your lemonade now costs ${UserInterface.FormatDouble(pricePerCup)} per cup.");
            }
        }

    }
}
