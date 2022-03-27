namespace viden.Domain.Entities;

public class ArticleVersion: BaseEntity
{
    public string Title { get; set; } = default!;
    public string? Thumbnail { get; set; }
    public string? Description { get; set; }
    public virtual Category Content { get; set; } = default!;
    public virtual Category? Component { get; set; }
    public virtual List<Category>? Technologies { get; set; }
    public virtual List<Category>? Restrictions { get; set; }

    public string? MarkdownContent { get; set; }
}