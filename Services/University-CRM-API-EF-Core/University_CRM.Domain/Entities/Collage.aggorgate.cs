using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_CRM.Domain.Entities
{
    public partial class Collage
    {
        public Collage()
        {
            Departments = new List<Department>();
        }

        public void UpdateNames(string nameArabic, string nameEnglish)
        {
            NameArabic = nameArabic;
            NameEnglish = nameEnglish;
        }
        public void UpdateDescriptions(string? descriptionArabic, string? descriptionEnglish)
        {
            DescriptionArabic = descriptionArabic;
            DescriptionEnglish = descriptionEnglish;
        }
    }
}
