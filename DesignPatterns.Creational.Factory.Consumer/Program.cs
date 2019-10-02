using System;

namespace DesignPatterns.Creational.Factory.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxFactory factory = new TaxFactory();

            ITax itax = factory.GetTax(1);//1 for ultralowsavingfund
            Console.WriteLine("tax for ultra low fund " + itax.CalculateTax(10000));

            ITax itax2 = factory.GetTax(2);//2 for taxsavingfund
            Console.WriteLine("tax for tax saving mutual fund " + itax2.CalculateTax(10000));

            Console.ReadLine();
        }
    }
}
