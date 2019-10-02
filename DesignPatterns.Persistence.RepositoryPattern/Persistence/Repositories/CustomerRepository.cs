using DesignPatterns.Persistence.RepositoryPattern.Models;
using DesignPatterns.Persistence.RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Persistence.RepositoryPattern.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public BankAccountsDBContext BankAccountsContext
        {
            get
            {
                return Context as BankAccountsDBContext;
            }        
        }
        public CustomerRepository(BankAccountsDBContext context) : base(context)
        {

        }

        public IEnumerable<Customer> GetCustomersWithoutKYC()
        {
            //var customer = BankAccountsContext.Customer.Where(c => c.Id == 1).Single();
            //BankAccountsContext.Customer.Add(new Customer());
            //BankAccountsContext.Customer.Update(customer);
            //customer.FirstName = "Naya FirstNAme";

            //BankAccountsContext.SaveChanges();

            return BankAccountsContext.Customer.Where(c => !c.KycState).ToList();
        }
    }
}
