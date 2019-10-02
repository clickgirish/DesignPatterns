namespace DesignPatterns.Creational.Factory
{
    public class TaxSavingMutualFund : ITax
    {
        public decimal CalculateTax(decimal moneyToTaxed)
        {
            return moneyToTaxed * (decimal)0.1;
        }
    }
}
