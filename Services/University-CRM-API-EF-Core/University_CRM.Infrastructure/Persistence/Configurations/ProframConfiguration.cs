using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_CRM.Domain.Entities;

namespace University_CRM.Infrastructure.Persistence.Configurations
{
    public class ProframConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.Property(p => p.NameArabic).HasMaxLength(100);
            builder.Property(p => p.NameEnglish).HasMaxLength(100);
            builder.Property(p => p.DescriptionArabic).HasMaxLength(1000);
            builder.Property(p => p.DescriptionEnglish).HasMaxLength(1000);
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.ModifiedBy).HasMaxLength(100);
            builder.Property(p => p.DeletedBy).HasMaxLength(100);

            builder.HasKey(key => key.ProgramId);

            builder.HasOne(rel => rel.ProgramType)
                .WithMany(rel => rel.Programs)
                .HasForeignKey(FK => FK.ProgramTypeId);
        }
    }
}
