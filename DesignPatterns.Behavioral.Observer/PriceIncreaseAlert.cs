using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public static class PriceIncreaseAlert
    {
        public delegate void PriceChanged(string message);

        //public static event PriceChanged OnPriceChanged;

        public static PriceChanged OnPriceChanged;

        public static void NotifyAlert(decimal price)
        {
            if (price > 100)
                OnPriceChanged?.Invoke("Price is increased more than 100");
        }
    }
}
