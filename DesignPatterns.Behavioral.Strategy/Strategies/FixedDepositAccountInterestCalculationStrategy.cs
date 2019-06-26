using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    class FixedDepositAccountInterestCalculationStrategy : IInterestCalculationStrategy
    {
        public decimal CalculateInterest()
        {
            // logic for calculating interest specific to Fixed Deposit Account.
            return 3.3M;
        }
    }
}
