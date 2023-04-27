namespace LemonadeStandGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeatherConditions.GetTemperature());
            Console.WriteLine(WeatherConditions.GetConditions());
        }
    }
}