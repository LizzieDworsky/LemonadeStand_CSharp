using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStandGame
{
    internal class Game
    {
        public Player player;
        public string[] daysOfWeek;

        public Game()
        {
            //Console.WriteLine("Please enter your username:");
            //string username = Console.ReadLine();
            player = new Player("Lizzie");
            daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }

        public void RunGame()
        {
            DisplayWelcome();
            for (int i = 0; i < 2; i++)
            {
                RunEachDay(i-1);
            }
            
        }

        public void RunEachDay(int dayIndex)
        {
            if (dayIndex == -1)
            {
                Console.WriteLine("Today is Sunday");
            }
            else
            {
                Console.WriteLine($"Today is {daysOfWeek[dayIndex]}");
            }
            Console.WriteLine(WeatherPrediction.Forecast(daysOfWeek[dayIndex+1]));
            RunPurchases();
            player.SetRecipe();
            player.SetPrice();
        }

        private void DisplayWelcome()
        {
            Console.WriteLine(@$"
            Welcome {this.player.username} to the game Lemonade Stand.

            You will have 7 days to make as much money as you can.
            If your bank account goes negative, the game will end.
            
            The weather and price affect how many customers will buy your lemonade.
            Have fun!
            ");
        }

        private void RunPurchases()
        {
            Store.SetPrices();
            player.BuyProduct("cups", player.numberCups, Store.cupCost);
            player.BuyProduct("lemons", player.numberLemons, Store.lemonCost);
            player.BuyProduct("cups of sugar", player.numberSugar, Store.sugarCost);
            player.BuyProduct("cubes of ice", player.numberIce, Store.iceCost);
        }
    }
}
