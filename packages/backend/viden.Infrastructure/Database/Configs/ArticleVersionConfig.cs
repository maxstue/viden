using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using viden.Domain.Entities;

namespace viden.Infrastructure.Database.Configs;

public class ArticleVersionConfig : IEntityTypeConfiguration<ArticleVersion>
{
    public void Configure(EntityTypeBuilder<ArticleVersion> builder)
    {
        builder.ToTable("ArticleVersions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

        builder.HasOne(x => x.Content).WithMany();
        builder.HasOne(x => x.Component).WithMany();
        // TODO check how to do
        builder.HasMany(x => x.Technologies).WithMany("ArticleVersion")
            .UsingEntity("ArticleVersionTechnologies");
        builder.HasMany(x => x.Restrictions).WithMany("ArticleVersion")
            .UsingEntity("ArticleVersionRestrictions");
    }
}