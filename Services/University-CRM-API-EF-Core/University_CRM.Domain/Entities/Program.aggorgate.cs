using University_CRM.Domain.Common;
using University_CRM.Domain.Enums;

namespace University_CRM.Domain.Entities
{
    public partial class Program : AuditEntity
    {
        public Program(string nameArabic, string nameEnglish, int departmentId, ProgramTypeEnum programTypeId)
        {
            NameArabic = nameArabic;
            NameEnglish= nameEnglish;
            DepartmentId= departmentId;
            ProgramTypeId = programTypeId;
        }
        public static Program Create(string nameArabic, string nameEnglish, int departmentId, ProgramTypeEnum programTypeId)
            => new Program(nameArabic, nameEnglish, departmentId, programTypeId);
        public void AddDescription(string descriptionArabic, string descriptionEnglish)
        {
            DescriptionArabic = descriptionArabic;
            DescriptionEnglish = descriptionEnglish;
        }
    }
}