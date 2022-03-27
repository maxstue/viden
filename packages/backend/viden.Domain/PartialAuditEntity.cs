namespace viden.Domain;

public class PartialAuditEntity: BaseEntity
{    
    public DateTime CreatedTime { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime DeletedAt { get; set; }
    public string DeletedBy { get; set; }
}