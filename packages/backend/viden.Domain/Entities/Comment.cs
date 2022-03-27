namespace viden.Domain.Entities;

public class Comment: AuditEntity
{
    public string Message { get; set; }
    public virtual Article Article { get; set; }
}