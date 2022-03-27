using viden.Domain.Enums;

namespace viden.Domain.Entities;

public class Category: AuditEntity
{
    public string Name { get; set; }
    public CategoryType Type { get; set; }
}