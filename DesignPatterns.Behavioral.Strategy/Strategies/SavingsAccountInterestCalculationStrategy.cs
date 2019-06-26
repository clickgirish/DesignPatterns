﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    public class SavingsAccountInterestCalculationStrategy : IInterestCalculationStrategy
    {
        public decimal CalculateInterest()
        {
            // logic for calculating interest specific to Savings Account.
            return 1.1M;
        }
    }
}