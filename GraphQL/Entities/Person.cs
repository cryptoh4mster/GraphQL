using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GraphQL.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
