namespace viden.Domain.Entities;

[StronglyTypedId(jsonConverter: StronglyTypedIdJsonConverter.SystemTextJson)]
public partial struct TenantId {}

public class Tenant
{
    public TenantId Id { get; } = TenantId.New();
}