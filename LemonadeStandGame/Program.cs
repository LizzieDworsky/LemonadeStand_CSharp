namespace LemonadeStandGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store.SetPrices();
            Player amy = new Player();
            amy.buyProduct();
        }
    }
}