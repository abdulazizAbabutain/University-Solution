using MediatR;
using University_CRM.Application.Common.Models;

namespace University_CRM.Application.Features.Programs.Queries.GetProgram
{
    public class GetProgramQuery : IRequest<ProgramDto>
    {
        public int Id { get; set; }
    }
}
