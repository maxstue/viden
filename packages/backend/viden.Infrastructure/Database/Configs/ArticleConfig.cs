using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using viden.Domain.Entities;
using viden.Domain.Enums;

namespace viden.Infrastructure.Database.Configs;

public class ArticleConfig: IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable("Articles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

        builder.HasMany(x => x.Versions).WithOne();
        builder.Property(x => x.Stage)
            .HasConversion<string>(new EnumToStringConverter<ArticleStage>());
        
        builder.HasMany(x => x.Comments).WithOne();
        builder.HasMany(x => x.Corrections).WithOne();
    }
}