namespace viden.Domain.Entities;

public class Tenant: PartialAuditEntity
{
    public string Name { get; set; }
    public virtual List<Group> Groups { get; set; }
    public virtual Setting Setting { get; set; }
}