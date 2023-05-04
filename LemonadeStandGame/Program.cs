namespace LemonadeStandGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeatherPrediction.Forecast());
            Console.WriteLine(WeatherPrediction.ActualWeather());
            Store.SetPrices();
            Player amy = new Player();
            amy.SetRecipe();
            amy.SetPrice();
        }
    }
}