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
            //builder.HasKey(key => new {key.CourseId, key.CoursePrerequisiteId});
        }
    }
}
