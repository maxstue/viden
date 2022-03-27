namespace viden.Domain.Entities;

public class Group: PartialAuditEntity
{
    public string Name { get; set; }
    public virtual Setting Setting { get; set; }
    public virtual List<User> Members { get; set; }
}