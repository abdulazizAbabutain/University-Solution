using University_CRM.Domain.Common;

namespace University_CRM.Domain.Entities
{
    public partial class Program : AuditEntity
    {
        public int ProgramId { get; private set; }
        public string NameArabic { get; private set; }
        public string NameEnglish { get; private set; }
        public string DescriptionArabic { get; private set; }
        public string DescriptionEnglish { get; private set; }
        public Department Department { get; private set; }
        public int DepartmentId { get; private set; }
        public ProgramType ProgramType { get; set; }
        public int ProgramTypeId { get; set; }
        public List<ProgramCourse> Courses { get; private set; }
    }
}