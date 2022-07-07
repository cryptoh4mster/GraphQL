using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors.Definitions;

namespace GraphQL.Graphql
{
    public class AddCompanyPayloadType : ObjectType<AddCompanyPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddCompanyPayload> descriptor)
        {
            descriptor.Description("Представляет результат операции по добавлению компании");

            descriptor.Field(c => c.Company).Description("Представляет добавленную компанию");
            
            base.Configure(descriptor);
        }
    }
}
