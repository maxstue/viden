using viden.Domain.Enums;

namespace viden.Domain.Entities;

public class Article: AuditEntity
{
    public ArticleStage Stage { get; set; }
    
    public virtual List<ArticleVersion> Versions { get; set; }

    public virtual List<Comment>? Comments { get; set; }
    public virtual List<Comment>? Corrections { get; set; }
    
    public DateTime? RecalledAt { get; set; }
    public virtual User? RecalledBy { get; set; }
    public DateTime? PublishedAt { get; set; }
    public virtual User? PublishedBy { get; set; }
}