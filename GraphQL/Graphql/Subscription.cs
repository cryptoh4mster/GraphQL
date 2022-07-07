using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Entities;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL.Graphql
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Company OnCompanyAdded([EventMessage] Company company) => company;
    }
}
