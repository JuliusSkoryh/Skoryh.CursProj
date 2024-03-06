using Microsoft.EntityFrameworkCore;
using Domain.Abstractions.RepositoryInterfaces;
using Domain.Enteties;
using Infrastructure;

namespace WebApplication1.Repositiries
{
    internal class PassRepository : IPassReposytory
    {
        protected readonly ApplicationDbContext DbContext;
        protected PassRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Add(Pass pass)
        {
            DbContext.Passes.Add(pass);
        }

        public async Task<List<Pass>> GetAllAsync()
        {
            return await DbContext.Passes.ToListAsync();

        }

        public async Task<Pass?> GetByIdAsync(Guid id)
        {
            return await DbContext.Passes.FirstOrDefaultAsync(e => e.PassId == id);

        }

        public void RemoveById(Pass pass)
        {
            DbContext.Passes.Remove(pass);
        }

        public void Update(Pass pass)
        {
            DbContext.Passes.Update(pass);
        }
    }
}
