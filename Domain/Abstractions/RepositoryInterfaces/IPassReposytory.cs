using Domain.Enteties;

namespace Domain.Abstractions.RepositoryInterfaces
{
    public interface IPassReposytory
    {
        Task<Pass?> GetByIdAsync(Guid id);
        Task<List<Pass>> GetAllAsync();
        void Add(Pass pass);
        void Update(Pass pass);
        void RemoveById(Pass pass);
    }
}
