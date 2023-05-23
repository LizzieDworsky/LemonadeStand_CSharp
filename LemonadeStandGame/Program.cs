// As a developer, I want to make good, consistent commits. 
//
// As a player, I want a weather system that includes a forecast and actual weather, so that I can get a predicted forecast for a day (or week)
// and then what the actual weather is on the given day. ✅
//
// As a player, I want to be able to go to the store to purchase items (lemons, sugar, ice, and cups) so that I can make lemonade to sell. ✅
//
// As a player, the price of the product as well as weather/temperature should affect demand, so that if the price is too high,
// sales will decrease, or if the price is too low, sales will increase, etc.  ✅
//
// As a player, I want each customer to be a separate object with its own chance of buying a glass of lemonade, so that how much lemonade is
// purchased and how much a customer is willing to pay will vary from customer to customer. ✅
//
// As a player, I want the ability to make a recipe for my lemonade, so that I can include x-amount of lemons, x-amount of sugar, and x-amount of ice.  ✅
//
// As a player, I want my game to be playable for at least seven days. ✅
//
// As a player, I want my daily profit or loss displayed at the end of each day, so that I know how much money my lemonade stand has made.
// I also want my total profit or loss to be a running total that is displayed at the end of each day, so that I know how much money my lemonade stand has made.  ✅
//
// As a player, I want the basic Lemonade Stand gameplay to be present.
//
// As a developer, I want to implement the SOLID design principles as well as C# best practices in my project, so that the project is as well-designed as possible. 
//
// As a developer, I want to pinpoint at least two places where I used one of the SOLID design principles and discuss my reasoning,
// so that I can properly understand good code design. Minimum of two SOLID design principles must be used.  
//
// As a developer, I want to implement validation across the app, so there is no way to crash the program.
// Ie, you cannot buy more ingredients than you can afford, you cannot pour more pitchers than you have ingredients to support, and so on.
// This should also include a game over scenario if you run out of money before the end of the week.

namespace LemonadeStandGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
        }
    }
}