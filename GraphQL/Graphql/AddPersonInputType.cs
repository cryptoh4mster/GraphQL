using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace GraphQL.Graphql
{
    public class AddPersonInputType : InputObjectType<AddPersonInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddPersonInput> descriptor)
        {
            descriptor.Description("Представляет входные данные для добавления работника");

            descriptor.Field(c => c.Name).Description("Представляет имя работника");
            descriptor.Field(c => c.Age).Description("Представляет возраст работника");
            descriptor.Field(c => c.CompanyId).Description("Представляет ID компании работника");
            descriptor.Field(c => c.Level).Description("Представляет уровень работника");
            base.Configure(descriptor);
        }
    }
}
