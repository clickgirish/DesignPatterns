namespace DesignPatterns.Creational.Factory
{
    public class TaxFactory {

        public ITax GetTax(int fundType) {
            ITax tax = null;

            if (fundType == 1) {
                tax = new UltraLowFund();
            }
            if (fundType == 2)
            {
                tax = new TaxSavingMutualFund();
            }
            if (fundType == 3)
            {
                tax = new FrenklinMutualFund();
            }

            return tax;
        }
    }
}
