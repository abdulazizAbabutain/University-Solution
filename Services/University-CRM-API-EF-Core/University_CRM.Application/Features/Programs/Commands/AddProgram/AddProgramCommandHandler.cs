using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_CRM.Application.Common.Exceptions;
using University_CRM.Application.Common.Interface;
using University_CRM.Domain.Entities;

namespace University_CRM.Application.Features.Programs.Commands;

public class AddProgramCommandHandler : IRequestHandler<AddProgramCommand>
{
    private readonly IRepositoryManager repositoryManager;

    public AddProgramCommandHandler(IRepositoryManager repositoryManager)
    {
        this.repositoryManager = repositoryManager;
    }
    public async Task<Unit> Handle(AddProgramCommand request, CancellationToken cancellationToken)
    {
        if (!(await repositoryManager.DepartmentRepository.IsExistsAsync(dep => dep.DepartmentId == request.DeparetmentId, cancellationToken)))
            throw new NotFoundException("Not Found");

        var program = Program.Create(request.NameArabic, request.NameEnglish, request.DeparetmentId, request.ProgramTypeId);
        program.AddDescription(request.DescriptionArabic, request.DescriptionEnglish);

        await repositoryManager.ProgramRepository.AddAsync(program);

        var programId = await repositoryManager.SaveAsync(cancellationToken);

        return Unit.Value;

    }
}
