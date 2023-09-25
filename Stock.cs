using System;

namespace Day6
{
    public delegate void StockPriceChagedHandler(Stock stock, decimal oldPrice);

    public class Stock
    {
        private decimal price;
        public decimal Price { get; set; }

        public event StockPriceChagedHandler OnPriceChanged;

        public void ChangeStockPriceByPercent(decimal percent)
        {
            decimal oldPrice = this.price;
            this.price += Math.Round(this.price * percent, 2);

            if (OnPriceChanged != null)
            {
                OnPriceChanged(this, oldPrice);
            }
        }

    }
}
