using MediatR;
using University_CRM.Domain.Enums;

namespace University_CRM.Application.Features.Programs.Commands;

public class AddProgramCommand : IRequest
{
    public int DeparetmentId { get; set; }
    public string NameArabic { get; set; }
    public string NameEnglish { get; set; }
    public string? DescriptionArabic { get; set; }
    public string? DescriptionEnglish { get; set; }
    public ProgramTypeEnum ProgramTypeId { get; set; }
}
