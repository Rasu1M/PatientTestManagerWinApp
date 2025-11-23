using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatientTestManagerWinApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestManagerWinApp.infrastructure.Persistence.Configurations
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.ID);

            builder.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd()
                .IsRequired();
        }
    }
}
