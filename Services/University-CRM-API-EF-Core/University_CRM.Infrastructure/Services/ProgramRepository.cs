using University_CRM.Application.Common.Interface;
using University_CRM.Domain.Entities;
using University_CRM.Infrastructure.Persistence;

namespace University_CRM.Infrastructure.Services
{
    public sealed class ProgramRepository : GenericRepository<Program>, IProgramRepository
    {
        public ProgramRepository(ApplicationContext context) 
            : base(context)
        {
        }
    }
}
