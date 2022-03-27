using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using viden.Domain.Entities;

namespace viden.Infrastructure.Database.Configs;

public class GroupConfig: IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("Groups");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

        builder.HasIndex(x => x.Name).IsUnique();

        builder.HasMany(x => x.Members)
            .WithOne();

        builder.HasOne(x => x.Setting).WithMany(x => x.Groups);
    }
}