using System;

namespace Day6
{
    public class StockSubscriber
    {
        public StockSubscriber(Stock stock)
        {
            stock.OnPriceChanged += HandlePriceChanged;
        }

        public void HandlePriceChanged(Stock stock, decimal oldPrice)
        {
            Console.WriteLine($"Old price: {oldPrice}, New price: {stock.Price}");
        }
    }
}
