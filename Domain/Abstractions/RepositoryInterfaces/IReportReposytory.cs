using Domain.Enteties;

namespace Domain.Abstractions.RepositoryInterfaces
{
    public interface IReportReposytory
    {
        Task<Report?> GetByIdAsync(Guid id);
        Task<List<Report>> GetAllAsync();
        void Add(Report report);
        void RemoveById(Report report);
    }
}
