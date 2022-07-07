using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace GraphQL.Graphql
{
    public class AddCompanyInputType : InputObjectType<AddCompanyInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddCompanyInput> descriptor)
        {
            descriptor.Description("Представляет входные данные для добавления компании");
            descriptor.Field(c => c.Name).Description("Представляет имя компании");
            base.Configure(descriptor);
        }
    }
}
