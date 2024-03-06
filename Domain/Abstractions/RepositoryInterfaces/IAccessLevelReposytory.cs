using Domain.Enteties;

namespace Domain.Abstractions.RepositoryInterfaces
{
    public interface IAccessLevelReposytory
    {
        Task<AccessLevel?> GetByIdAsync(Guid id);
        Task<List<AccessLevel>> GetAllAsync();
        void Add(AccessLevel accessLevel);
        void Update(AccessLevel accessLevel);
        void Remove(AccessLevel accessLevel);
    }
}
