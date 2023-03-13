using University_CRM.Domain.Common;

namespace University_CRM.Domain.Entities
{
    public class ProgramCourse : AuditEntity
    {
        public int ProgreamId { get; set; }
        public Program Program { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int Level { get; set; }
        public bool IsOptional { get; set; }
    }
}