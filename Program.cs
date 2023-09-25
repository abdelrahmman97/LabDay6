using System;


namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stock stock = new Stock();
            stock.Price = 100;

            stock.OnPriceChanged += Stock_OnPriceChanged;
            stock.ChangeStockPriceByPercent(0.05m);
            stock.ChangeStockPriceByPercent(-0.02m);
            stock.ChangeStockPriceByPercent(0.00m);

        }

        static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice) { Console.WriteLine($"new price : {stock.Price}"); }
            if (stock.Price < oldPrice) { Console.WriteLine($"new price : {stock.Price}"); }
            if (stock.Price == oldPrice) { Console.WriteLine($"new price : {stock.Price}"); }
        }
    }
}