using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    interface IInterestCalculationStrategy
    {
        decimal CalculateInterest();
    }
}
