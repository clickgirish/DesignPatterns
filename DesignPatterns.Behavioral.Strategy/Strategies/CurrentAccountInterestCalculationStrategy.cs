using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    class CurrentAccountInterestCalculationStrategy : IInterestCalculationStrategy
    {
        public decimal CalculateInterest()
        {
            // logic for calculating interest specific to Current Account.
            return 2.2M;
        }
    }
}
