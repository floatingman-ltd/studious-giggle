using System;

namespace Domain
{
    public class Stock
    {

        public Stock(string symbol)
        {
            Symbol = symbol;
        }

        private decimal _price;
        public decimal Price
        {
            get => _price; set
            {
                if (_price == value) return;
                var lastPrice = _price;
                _price = value;
                OnPriceChanged(new PriceChangedEventArgs(lastPrice, _price));
            }
        }
        public string Symbol { get; }
        public static event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
            // if (PriceChanged != null) PriceChanged(this, e);
        }

    }
}
