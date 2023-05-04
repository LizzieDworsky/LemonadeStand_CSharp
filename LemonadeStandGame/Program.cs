namespace LemonadeStandGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeatherPrediction.Forecast());
            Console.WriteLine(WeatherPrediction.ActualWeather());
            Store.SetPrices();
            Customer josh = new Customer();
            Console.WriteLine(josh.PurchaseLemonade());
        }
    }
}