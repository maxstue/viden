using System.Reflection;
using Microsoft.EntityFrameworkCore;
using viden.Domain.Entities;

namespace viden.Infrastructure.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Article> Articles { get; set; } = default!;
    public DbSet<ArticleVersion> ArticleVersions { get; set; } = default!;
    public DbSet<Category> Categories { get; set; } = default!;
    public DbSet<Comment> Comments { get; set; } = default!;
    public DbSet<Group> Groups { get; set; } = default!;
    public DbSet<Setting> Settings { get; set; } = default!;
    public DbSet<Tenant> Tenants { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Naming the schema
        builder.HasDefaultSchema("viden");
        // Set Extension for autogenerate the Id property
        // builder.HasPostgresExtension("uuid-ossp");
        // Rename alle Identity Tables

        // Apply entity configurations
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}