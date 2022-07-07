using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>();
    }
}
