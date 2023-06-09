﻿using University_CRM.Application.Common.Interface;
using University_CRM.Infrastructure.Persistence;

namespace University_CRM.Infrastructure.Services
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ICollageRepository> _collageRepository;
        private readonly Lazy<IDepartmentRepository> _departmentRepository;  
        private readonly Lazy<IProgramRepository> _programRepository;
     
        private readonly ApplicationContext _applicationContext;

        public RepositoryManager(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

            _collageRepository = new Lazy<ICollageRepository>(() 
                => new CollageRepository(_applicationContext!));
            _departmentRepository = new Lazy<IDepartmentRepository>(() 
                => new DepartmentRepository(_applicationContext!));
            _programRepository = new Lazy<IProgramRepository>(()
                => new ProgramRepository(_applicationContext!));
        }

        public ICollageRepository CollageRepository => _collageRepository.Value;
        public IDepartmentRepository DepartmentRepository => _departmentRepository.Value;
        public IProgramRepository ProgramRepository => _programRepository.Value;

        public async Task<int> SaveAsync(CancellationToken cancellationToken)
            => await _applicationContext.SaveChangesAsync(cancellationToken);
    }
}
