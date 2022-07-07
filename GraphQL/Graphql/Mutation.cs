using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GraphQL.EF;
using GraphQL.Entities;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;

namespace GraphQL.Graphql
{
    public class Mutation
    {
        [UseDbContext(typeof(ApplicationContext))]
        public async Task<AddCompanyPayload> AddCompanyAsync(AddCompanyInput input, [ScopedService] ApplicationContext db, [Service] ITopicEventSender eventSender, CancellationToken cancellationToken)
        {
            var company = new Company
            {
                Name = input.Name
            };

            db.Companies.Add(company);
            await db.SaveChangesAsync(cancellationToken);

            await eventSender.SendAsync(nameof(Subscription.OnCompanyAdded), company, cancellationToken);

            return new AddCompanyPayload(company);
        }

        [UseDbContext(typeof(ApplicationContext))]
        public async Task<AddPersonPayload> AddPersonAsync(AddPersonInput input, [ScopedService] ApplicationContext db)
        {
            var person = new Person
            {
                Name = input.Name,
                Age = input.Age,
                CompanyId = input.CompanyId,
                Level = input.Level
            };

            db.Persons.Add(person);
            await db.SaveChangesAsync();

            return new AddPersonPayload(person);
        }
    }
}
