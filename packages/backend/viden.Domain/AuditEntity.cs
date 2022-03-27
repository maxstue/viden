using viden.Domain.Entities;

namespace viden.Domain;

public class AuditEntity: BaseEntity
{
    public DateTime CreatedTime { get; set; }
    public virtual User CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public virtual User? UpdatedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public virtual User? DeletedBy { get; set; }
}