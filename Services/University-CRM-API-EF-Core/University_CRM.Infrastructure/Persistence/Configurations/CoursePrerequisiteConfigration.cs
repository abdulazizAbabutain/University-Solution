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
    public class CoursePrerequisiteConfigration : IEntityTypeConfiguration<CoursePrerequisite>
    {
        public void Configure(EntityTypeBuilder<CoursePrerequisite> builder)
        {
            builder.HasKey(key => new { key.CourseId, key.CoursePrerequisiteId });

            builder.HasOne(rel => rel.Course)
                .WithMany(rel => rel.Courses)
                .HasForeignKey(FK => FK.CourseId);

            builder.HasOne(rel => rel.CoursePrerequisites)
                .WithMany(rel => rel.CoursePrerequisites)
                .HasForeignKey(FK => FK.CoursePrerequisiteId);
        }
    }
}
