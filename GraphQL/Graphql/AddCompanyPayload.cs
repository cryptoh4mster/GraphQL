using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Entities;

namespace GraphQL.Graphql
{
    public class AddCompanyPayload
    {
        public Company Company { get; set; }
        public AddCompanyPayload(Company company)
        {
            Company = company;
        }
    }
}
