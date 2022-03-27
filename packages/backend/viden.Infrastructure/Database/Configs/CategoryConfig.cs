using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using viden.Domain.Entities;
using viden.Domain.Enums;

namespace viden.Infrastructure.Database.Configs;

public class CategoryConfig: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Comments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

        builder.HasIndex(x => x.Name).IsUnique();
        
        builder.Property(x => x.Type)
            .HasConversion<string>(new EnumToStringConverter<CategoryType>());
    }
}