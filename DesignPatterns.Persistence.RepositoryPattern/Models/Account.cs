using System;
using System.Collections.Generic;

namespace DesignPatterns.Persistence.RepositoryPattern.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountCustomer = new HashSet<AccountCustomer>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public string State { get; set; }
        public int? AccountTypeId { get; set; }

        public AccountType AccountType { get; set; }
        public ICollection<AccountCustomer> AccountCustomer { get; set; }
    }
}
