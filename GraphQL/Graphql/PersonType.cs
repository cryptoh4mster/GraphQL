using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.EF;
using GraphQL.Entities;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace GraphQL.Graphql
{
    public class PersonType : ObjectType<Person>
    {
        protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
        {
            descriptor.Description("Работник и компания, в которой он работает");

            descriptor.Field(x => x.Id).Description("ID работника");
            descriptor.Field(x => x.Age).Description("Возраст работника");
            descriptor.Field(x => x.Level).Description("Уровень работника");
            descriptor.Field(x => x.Name).Description("Имя работника");
            descriptor.Field(x => x.CompanyId).Description("ID компании, к которой относится работник");
            descriptor
                .Field(x => x.Company)
                .ResolveWith<Resolvers>(p => p.GetCompany(default!, default!))
                .UseDbContext<ApplicationContext>()
                .Description("Компания, к которой принадлежит работник");
        }

        private class Resolvers
        {
            public Company GetCompany([Parent] Person person, [ScopedService] ApplicationContext db)
            {
                return db.Companies.FirstOrDefault(x => x.Id == person.CompanyId);
            }
        }
    }
}
