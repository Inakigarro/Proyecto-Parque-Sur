using Cps.Sports.Application.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cps.Sports.Persistence;

public class SportEntityTypeConfiguration : IEntityTypeConfiguration<Sport>
{
    public void Configure(EntityTypeBuilder<Sport> builder)
    {
        builder.HasKey(x => x.CorrelationId);

        builder.Property(x => x.CorrelationId);
        builder.Property(x => x.DisplayName);
    }
}