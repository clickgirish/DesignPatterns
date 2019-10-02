using DesignPatterns.Persistence.RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Persistence.RepositoryPattern.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetCustomersWithoutKYC();
    }
}
