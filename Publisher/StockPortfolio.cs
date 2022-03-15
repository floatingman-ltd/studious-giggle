using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Domain;

namespace Publisher
{
    public class StockPortfolio
    {
        public StockPortfolio()
        {
            var rnd = new Random();
            Add("goog");
            for (var i = 0; i < 10; i++)
            {
                _internal.First().Price = rnd.Next();
                Thread.Sleep(3000);
            }
        }

        public void Add(string symbol)
        {
            _internal.Add(new Stock(symbol));
        }

        private IList<Stock> _internal = new List<Stock>();

    }
}
