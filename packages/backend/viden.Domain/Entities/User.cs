using viden.Domain.ValueObjects;

namespace viden.Domain.Entities;

public class User: PartialAuditEntity
{
    public PersonName PersonName { get; set; }
    public string UserName { get; set; }
    public string? Email { get; set; }
    public string? Telephone { get; set; }
    public string? Motto { get; set; }
    public string? AvatarUrl { get; set; }
    public virtual Group Group { get; set; }
    public virtual Tenant Tenant { get; set; }
}