namespace University_CRM.Application.Common.Interface
{
    public interface IRepositoryManager
    {
        public ICollageRepository CollageRepository { get;}
        public IDepartmentRepository DepartmentRepository { get;}
        public IProgramRepository ProgramRepository { get; }
        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
