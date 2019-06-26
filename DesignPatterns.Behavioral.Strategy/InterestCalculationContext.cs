using DesignPatterns.Behavioral.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class InterestCalculationContext
    {
        private readonly Dictionary<AccountType, IInterestCalculationStrategy> strategies = new Dictionary<AccountType, IInterestCalculationStrategy>();

        public InterestCalculationContext()
        {
            strategies.Add(AccountType.Savings, new SavingsAccountInterestCalculationStrategy());
            strategies.Add(AccountType.Current, new CurrentAccountInterestCalculationStrategy());
            strategies.Add(AccountType.FixedDeposit, new FixedDepositAccountInterestCalculationStrategy());
        }

        public decimal GetCalculatedInterest(AccountType accountType)
        {
            return strategies[accountType].CalculateInterest();
        }
    }
}
