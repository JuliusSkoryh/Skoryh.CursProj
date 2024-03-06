using Domain.Enteties;

namespace Domain.Abstractions.RepositoryInterfaces
{
    public interface IEmployeeReposytory
    {
        Task<Employee?> GetByIdAsync(Guid id);
        Task<List<Employee>> GetAllAsync();
        void Add(Employee employee);
        void Update(Employee employee);
        void RemoveById(Employee employee);
    }
}
