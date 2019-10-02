using System;
using System.Collections.Generic;

namespace DesignPatterns.Persistence.RepositoryPattern.Models
{
    public partial class Person
    {
        public Person()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Address> Address { get; set; }
    }
}
