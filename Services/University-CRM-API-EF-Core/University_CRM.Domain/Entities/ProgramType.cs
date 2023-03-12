using University_CRM.Domain.Enums;

namespace University_CRM.Domain.Entities
{
    public class ProgramType
    {
        public ProgramTypeEnum ProgramTypeId { get; set; }
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public ICollection<Program> Programs { get; set; }
    }
}