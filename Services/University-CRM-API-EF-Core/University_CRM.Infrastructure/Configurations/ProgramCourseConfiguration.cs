using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_CRM.Domain.Entities;

namespace University_CRM.Infrastructure.Configurations
{
    public class ProgramCourseConfiguration : IEntityTypeConfiguration<ProgramCourse>
    {
        public void Configure(EntityTypeBuilder<ProgramCourse> builder)
        {
            builder.HasKey(PK => new { PK.CourseId, PK.ProgreamId});

            builder.HasOne(rel => rel.Program)
                .WithMany(rel => rel.Courses)
                .HasForeignKey(FK => FK.ProgreamId);

            builder.HasOne(rel => rel.Course)
                .WithMany(rel => rel.Programs)
                .HasForeignKey(FK => FK.CourseId);
        }
    }
}
