using System;
using System.Collections.Generic;

namespace DesignPatterns.Persistence.RepositoryPattern.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public int? PersonId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Person Person { get; set; }
    }
}
