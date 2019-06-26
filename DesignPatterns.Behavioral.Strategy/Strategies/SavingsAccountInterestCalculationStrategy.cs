using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    class SavingsAccountInterestCalculationStrategy : IInterestCalculationStrategy
    {
        public decimal CalculateInterest()
        {
            // logic for calculating interest specific to Savings Account.
            return 1.1M;
        }
    }
}
