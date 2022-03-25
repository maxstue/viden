namespace Viden.Domain.Entities;

[StronglyTypedId(jsonConverter: StronglyTypedIdJsonConverter.SystemTextJson)]
public partial struct GroupId {}

public class Group
{
    public GroupId Id { get; } = GroupId.New();
}