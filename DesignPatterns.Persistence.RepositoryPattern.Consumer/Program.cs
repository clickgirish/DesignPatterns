using DesignPatterns.Persistence.RepositoryPattern.Persistence;
using System;
using System.Linq;

namespace DesignPatterns.Persistence.RepositoryPattern.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new Models.BankAccountsDBContext()))
            {
                var customersWithoutKyc = unitOfWork.CustomerRepository.GetCustomersWithoutKYC();

                unitOfWork.Complete();

                foreach (var customer in customersWithoutKyc)
                {
                    Console.WriteLine(customer.FirstName);
                }
            }

            Console.Read();
        }
    }
}
