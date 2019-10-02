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
                
                foreach (var customer in customersWithoutKyc)
                {
                    customer.FirstName = $"{customer.FirstName} - UPDATED";
                    Console.WriteLine(customer.FirstName);
                }

                unitOfWork.Complete();
            }

            Console.Read();
        }
    }
}
