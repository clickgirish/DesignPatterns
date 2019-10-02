using DesignPatterns.Creational.Factory;
using System;

namespace DesignPatterns.Behavioral.Observer.Consumer2
{
    class Program
    {
        static void Main(string[] args)
        {
            FrenklinMutualFund frenklinMutualFund = new FrenklinMutualFund();

            PriceIncreaseAlert.OnPriceChanged += PriceIncreaseAlert_OnPriceChanged;

            Console.ReadLine();
        }

        private static void PriceIncreaseAlert_OnPriceChanged(string message)
        {
            Console.WriteLine("message to Consumer 2 " + message);
        }
    }
}
