using Microsoft.EntityFrameworkCore;
using Domain.Abstractions.RepositoryInterfaces;
using Domain.Enteties;
using Infrastructure;


namespace WebApplication1.Repositiries
{
    internal class CheckpointRepository : ICheckpointReposytory
    {
        protected readonly ApplicationDbContext DbContext;
        protected CheckpointRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Add(Checkpoint checkpoint)
        {
            DbContext.Checkpoints.Add(checkpoint);
        }

        public async Task<List<Checkpoint>> GetAllAsync()
        {
            return await DbContext.Checkpoints.ToListAsync();

        }

        public async Task<Checkpoint?> GetByIdAsync(Guid id)
        {
            return await DbContext.Checkpoints.FirstOrDefaultAsync(e => e.CheckpointId == id);
        }

        public async Task<bool> IsCheckpointLock(Guid id)
        {
            var checkpoint = await DbContext.Checkpoints.Where(e => e.CheckpointId == id).FirstOrDefaultAsync();
            return checkpoint.IsLock;
        }

        public void RemoveById(Checkpoint checkpoint)
        {
            DbContext.Checkpoints.Remove(checkpoint);
        }

        public void Update(Checkpoint checkpoint)
        {
            DbContext.Checkpoints.Update(checkpoint);
        }
    }
}
