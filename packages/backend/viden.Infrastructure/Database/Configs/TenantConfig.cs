using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using viden.Domain.Entities;

namespace viden.Infrastructure.Database.Configs;

public class TenantConfig: IEntityTypeConfiguration<Tenant>
{
    public void Configure(EntityTypeBuilder<Tenant> builder)
    {
        builder.ToTable("Tenants");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

        builder.HasIndex(x => x.Name).IsUnique();

        builder.HasMany(x => x.Groups)
            .WithOne();

        builder.HasOne(x => x.Setting).WithMany(x => x.Tenants);
    }
}