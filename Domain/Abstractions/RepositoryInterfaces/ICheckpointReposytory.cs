using Domain.Enteties;

namespace Domain.Abstractions.RepositoryInterfaces
{
    public interface ICheckpointReposytory
    {
        Task<Checkpoint?> GetByIdAsync(Guid id);
        Task<List<Checkpoint>> GetAllAsync();
        void Add(Checkpoint checkpoint);
        void Update(Checkpoint checkpoint);
        void RemoveById(Checkpoint checkpoint);
        Task<bool> IsCheckpointLock(Guid id);
    }
}
