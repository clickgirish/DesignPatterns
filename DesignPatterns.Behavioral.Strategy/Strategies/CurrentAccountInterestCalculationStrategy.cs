using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    public class CurrentAccountInterestCalculationStrategy : IInterestCalculationStrategy
    {
        public decimal CalculateInterest()
        {
            // logic for calculating interest specific to Current Account.
            return 2.2M;
        }
    }
}
