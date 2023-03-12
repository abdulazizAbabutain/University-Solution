namespace University_CRM_UI.MVC.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string NameArabic { get; set; } = string.Empty;
        public string NameEnglish { get; set; } = string.Empty;
        public string? DescriptionArabic { get; set; }
        public string? DescriptionEnglish { get; set; }
    }
}
