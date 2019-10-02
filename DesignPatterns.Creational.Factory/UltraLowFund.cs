using System;

namespace DesignPatterns.Creational.Factory
{
    public class UltraLowFund : ITax
    {
        public decimal CalculateTax(decimal moneyToTaxed)
        {
            return moneyToTaxed * (decimal)0.3;
        }
    }
}
