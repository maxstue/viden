namespace Kj.Api.GraphQl.Resolvers;

public class RootQueryResolver: ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        base.Configure(descriptor);
        descriptor.Description("This is the root resolver.");
    }
}