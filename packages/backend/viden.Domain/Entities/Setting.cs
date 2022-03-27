namespace viden.Domain.Entities;

public class Setting: PartialAuditEntity
{
    public string Name { get; set; }
    public Configuration Configuration { get; set; }
    
    public virtual List<Tenant> Tenants { get; set; }
    public virtual List<Group> Groups { get; set; }
}
