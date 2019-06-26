using DesignPatterns.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
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
