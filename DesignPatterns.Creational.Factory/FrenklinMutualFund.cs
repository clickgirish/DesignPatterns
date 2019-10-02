namespace DesignPatterns.Creational.Factory
{
    public class FrenklinMutualFund : ITax
    {
        public decimal CalculateTax(decimal moneyToTaxed)
        {
            return moneyToTaxed * (decimal)0.2;
        }
    }
}
