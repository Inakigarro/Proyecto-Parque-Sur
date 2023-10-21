using Cps.Sports.Application.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cps.Sports.Persistence;

public class CpsSportsDbContext : DbContext
{
    public CpsSportsDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected CpsSportsDbContext()
    {
    }

    public DbSet<Sport> Sports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new SportEntityTypeConfiguration())
            .HasDefaultSchema("Sports");
    }
}