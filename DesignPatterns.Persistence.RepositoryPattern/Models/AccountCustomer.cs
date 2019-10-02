using System;
using System.Collections.Generic;

namespace DesignPatterns.Persistence.RepositoryPattern.Models
{
    public partial class AccountCustomer
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }

        public Account Account { get; set; }
        public Customer Customer { get; set; }
    }
}
