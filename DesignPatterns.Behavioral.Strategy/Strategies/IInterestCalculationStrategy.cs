using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    public interface IInterestCalculationStrategy
    {
        decimal CalculateInterest();
    }
}
