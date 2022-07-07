using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Entities;

namespace GraphQL.Graphql
{
    public class AddPersonInput
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }
        public int CompanyId { get; set; }

        public AddPersonInput(string name, int age, string level, int companyId)
        {
            Name = name;
            Age = age;
            Level = level;
            CompanyId = companyId;
        }
    }
}
