namespace LemonadeStandGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeatherPrediction.Forecast());
            Store.SetPrices();
            Player amy = new Player();
            amy.BuyProduct();
        }
    }
}