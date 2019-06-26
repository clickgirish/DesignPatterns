using System;

namespace DesignPatterns.Behavioral.Strategy.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPattern();

            Console.ReadLine();
        }

        static void StrategyPattern()
        {
            var context = new InterestCalculationContext();
            Console.WriteLine(context.GetCalculatedInterest(AccountType.Savings));
            Console.WriteLine(context.GetCalculatedInterest(AccountType.Current));
            Console.WriteLine(context.GetCalculatedInterest(AccountType.FixedDeposit));
        }
    }
}
