using University_CRM.Domain.Common;

namespace University_CRM.Domain.Entities
{
    public partial class Collage : AuditEntity
    {
        public int CollageId { get; set; }
        public string NameArabic { get; set; } = string.Empty;
        public string NameEnglish { get; set; } = string.Empty;
        public string? DescriptionArabic { get; set; }
        public string? DescriptionEnglish { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
