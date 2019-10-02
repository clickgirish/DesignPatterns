using System;
using System.Collections.Generic;

namespace DesignPatterns.Persistence.RepositoryPattern.Models
{
    public partial class Customer
    {
        public Customer()
        {
            AccountCustomer = new HashSet<AccountCustomer>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool KycState { get; set; }

        public ICollection<AccountCustomer> AccountCustomer { get; set; }
    }
}
