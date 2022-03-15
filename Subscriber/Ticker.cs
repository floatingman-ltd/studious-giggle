using System;
using Domain;

namespace Subscriber
{
    public class Ticker
    {
        public Ticker()
        {
            Stock.PriceChanged += Tick;
        }



        private void Tick(object sender, PriceChangedEventArgs e)
        {
            var direction = e.LastPrice > e.NewPrice ? "drops" : "rises";
            Console.WriteLine($"Price change: from {e.LastPrice} {direction} to {e.NewPrice} ");
        }
    }
}
