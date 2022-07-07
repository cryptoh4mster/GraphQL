using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Entities;

namespace GraphQL.Graphql
{
    public class AddPersonPayload
    {
        public Person Person { get; set; }

        public AddPersonPayload(Person person)
        {
            Person = person;
        }
    }
}
