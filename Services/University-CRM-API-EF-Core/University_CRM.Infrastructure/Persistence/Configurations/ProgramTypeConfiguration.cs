using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_CRM.Domain.Entities;

namespace University_CRM.Infrastructure.Persistence.Configurations
{
    public class ProgramTypeConfiguration : IEntityTypeConfiguration<ProgramType>
    {
        public void Configure(EntityTypeBuilder<ProgramType> builder)
        {
            builder.HasKey(PK => PK.ProgramTypeId);

            builder.Property(entity => entity.NameArabic)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(entity => entity.NameEnglish)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasData(
                new ProgramType
            {
                    ProgramTypeId = 1,
                    NameArabic = "بكالـوريوس", 
                    NameEnglish = "Bachelor\'s",
            });
        }
    }
}
