namespace Viden.Domain;

public class BaseEntity<TId>
{
    public TId Id { get; init; } = default!;
}