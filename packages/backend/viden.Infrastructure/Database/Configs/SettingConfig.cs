using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using viden.Domain.Entities;

namespace viden.Infrastructure.Database.Configs;

public class SettingConfig: IEntityTypeConfiguration<Setting>
{
    public void Configure(EntityTypeBuilder<Setting> builder)
    {
        builder.ToTable("Settings");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

        builder.HasIndex(x => x.Name).IsUnique();
        builder.Property(b => b.Configuration)
            .HasColumnType("jsonb");
    }
}