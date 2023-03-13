using MediatR;

namespace University_CRM.Application.Features.Programs.Commands;

public class AddProgramCommand : IRequest<int>
{
    public int DeparetmentId { get; set; }
    public string NameArabic { get; set; }
    public string NameEnglish { get; set; }
    public string? DescriptionArabic { get; set; }
    public string? DescriptionEnglish { get; set; }
    public int ProgramTypeId { get; set; }
}
