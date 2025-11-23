using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatientTestManagerWinApp.Domain.Entities;

namespace PatientTestManagerWinApp.infrastructure.Persistence.Configurations
{
    public class PatientsConfiguration : BaseEntityConfiguration<Patient>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);

            builder.ToTable("Patients");

            builder.Property(e => e.Name)
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(e => e.Gender)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(e => e.UpdatedAt)
                .HasColumnType("datetime2(0)")
                .IsRequired(false);
        }
    }
}
