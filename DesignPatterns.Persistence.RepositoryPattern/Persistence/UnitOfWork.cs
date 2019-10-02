using DesignPatterns.Persistence.RepositoryPattern.Models;
using DesignPatterns.Persistence.RepositoryPattern.Core.Repositories;
using DesignPatterns.Persistence.RepositoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Persistence.RepositoryPattern.Persistence.Repositories;

namespace DesignPatterns.Persistence.RepositoryPattern.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankAccountsDBContext context;
        public UnitOfWork(BankAccountsDBContext bankAccountsContext)
        {
            context = bankAccountsContext;
            CustomerRepository = new CustomerRepository(bankAccountsContext);
        }

        public ICustomerRepository CustomerRepository { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
