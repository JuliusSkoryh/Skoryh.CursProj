using Microsoft.EntityFrameworkCore;
using Domain.Abstractions.RepositoryInterfaces;
using Domain.Enteties;

namespace Infrastructure.Repositiries
{
    internal class AccesslevelRepository : IAccessLevelReposytory
    {
        protected readonly ApplicationDbContext DbContext;
        protected AccesslevelRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Add(AccessLevel accessLevel)
        {
            DbContext.AccessLevels.Add(accessLevel);
        }

        public async Task<List<AccessLevel>> GetAllAsync()
        {
            return await DbContext.AccessLevels.ToListAsync();
        }

        public async Task<AccessLevel?> GetByIdAsync(Guid id)
        {
            return await DbContext.AccessLevels.FirstOrDefaultAsync(e => e.AccessLevelId == id);
        }

        public void Remove(AccessLevel accessLevel)
        {
            DbContext.AccessLevels.Remove(accessLevel);
        }

        public void Update(AccessLevel accessLevel)
        {
            DbContext.AccessLevels.Update(accessLevel);
        }
    }
}
