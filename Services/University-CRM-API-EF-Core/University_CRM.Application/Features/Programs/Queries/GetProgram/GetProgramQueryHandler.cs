using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_CRM.Application.Common.Exceptions;
using University_CRM.Application.Common.Interface;
using University_CRM.Application.Common.Models;

namespace University_CRM.Application.Features.Programs.Queries.GetProgram
{
    public class GetProgramQueryHandler : IRequestHandler<GetProgramQuery, ProgramDto>
    {
        private readonly IRepositoryManager repositoryManager;

        public GetProgramQueryHandler(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }
        public async Task<ProgramDto> Handle(GetProgramQuery request, CancellationToken cancellationToken)
        {
            var programEntity = await repositoryManager.ProgramRepository.GetAsync(prom => prom.ProgramId == request.Id, cancellationToken);

            if (programEntity is null)
                throw new NotFoundException("not found");

            var dto = new ProgramDto
            {
                ProgramId = programEntity.ProgramId,
                NameArabic = programEntity.NameArabic,
                NameEnglish = programEntity.NameEnglish,
                DescriptionArabic = programEntity.DescriptionArabic,
                DescriptionEnglish = programEntity.DescriptionEnglish,
            };
            return dto;
        }
    }
}
