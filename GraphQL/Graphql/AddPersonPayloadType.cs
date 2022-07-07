using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors.Definitions;

namespace GraphQL.Graphql
{
    public class AddPersonPayloadType : ObjectType<AddPersonPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddPersonPayload> descriptor)
        {
            descriptor.Description("Представляет результат операции по добавлению работника");

            descriptor.Field(c => c.Person).Description("Представляет добавленного работника");
            base.Configure(descriptor);
        }
    }
}
