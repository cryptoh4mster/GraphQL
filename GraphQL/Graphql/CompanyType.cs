using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.EF;
using GraphQL.Entities;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL.Graphql
{
    public class CompanyType : ObjectType<Company>
    {
        protected override void Configure(IObjectTypeDescriptor<Company> descriptor)
        {
            descriptor.Description("Компания и ее работники");

            descriptor.Field(x => x.Id).Description("ID компании");
            descriptor.Field(x => x.Name).Description("Название компании");
            //descriptor.Field(x => x.Persons).Ignore();

            descriptor.Field(x => x.Persons)
                .ResolveWith<Resolvers>(p => p.GetPersons(default!, default!))
                .UseDbContext<ApplicationContext>()
                .Description("Работники, которые относятся к компании");
        }

        private class Resolvers
        {
            public IQueryable<Person> GetPersons([Parent] Company company, [ScopedService] ApplicationContext db)
            {
                return db.Persons.Where(x => x.CompanyId == company.Id);
            }
        }
    }
}
