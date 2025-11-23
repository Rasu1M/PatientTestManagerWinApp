using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatientTestManagerWinApp.Domain.Entities;

namespace PatientTestManagerWinApp.infrastructure.Persistence.Configurations
{
    public class TestsConfiguration : BaseEntityConfiguration<Test>
    {
        public override void Configure(EntityTypeBuilder<Test> builder)
        {
            base.Configure(builder);

            builder.ToTable("Tests");

            builder.Property(e => e.Name)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(e => e.PerformedOn)
                .HasColumnType("datetime2(0)")
                .IsRequired();

            builder.Property(e => e.Result)
                .HasColumnType("deimal(6,3)")
                .IsRequired();

            builder.Property(e => e.IsWithinThreshold)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(e => e.UpdatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired(false);
        }
    }
}
