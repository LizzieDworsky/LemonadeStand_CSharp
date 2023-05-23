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
            daysOfWeek = new string[8] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Monday" };
        }

        public void RunGame()
        {
            DisplayWelcome();
            for (int i = 0; i < 8; i++)
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
            player.MakeLemonade();
            Console.WriteLine(WeatherPrediction.ActualWeather());
            CreateCustomersBuyLemonade(WeatherPrediction.weatherCond, WeatherPrediction.actualTemp);
            player.UnmakeLemonade();
        }

        private void CreateCustomersBuyLemonade(string weatherCondition, int weatherTemp)
        {
            player.todaysMoney = 0;
            int counter = 0;
            while (player.numberOfPitchers > 0 && counter < 16)
            {
                int cupsToSell = player.recipe["Cups"];
                while (cupsToSell > 0 && counter < 101)
                {
                    Customer customer = new Customer();
                    bool isBuying = customer.WillBuyLemonade(player.pricePerCup, weatherTemp, weatherCondition);
                    cupsToSell = player.SellLemonade(isBuying, cupsToSell);
                    counter++;
                }
                player.numberOfPitchers -= 1;
            }
            player.money += player.todaysMoney;
            Console.WriteLine($"Today you made ${UserInterface.FormatDouble(player.todaysMoney)}.\nYou now have ${UserInterface.FormatDouble(player.money)}");

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
