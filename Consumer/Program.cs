using System;
using Publisher;
using Subscriber;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Ticker();
            var p = new StockPortfolio();
        }
    }
}
