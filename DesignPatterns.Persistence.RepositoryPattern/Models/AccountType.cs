using System;
using System.Collections.Generic;

namespace DesignPatterns.Persistence.RepositoryPattern.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Account = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public string Description { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
