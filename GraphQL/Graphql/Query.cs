using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.EF;
using GraphQL.Entities;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL.Graphql
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Person> GetPerson([ScopedService] ApplicationContext db)
        {
            return db.Persons;
        }
        [UseDbContext(typeof(ApplicationContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Company> GetCompany([ScopedService] ApplicationContext db)
        {
            return db.Companies;
        }
    }
}
