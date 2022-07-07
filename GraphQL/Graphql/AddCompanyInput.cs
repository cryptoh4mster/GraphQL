using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Graphql
{
    public class AddCompanyInput
    {
        public string Name { get; set; }
        public AddCompanyInput(string name)
        {
            Name = name;
        }
    }
}
    