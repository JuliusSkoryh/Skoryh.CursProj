using Microsoft.EntityFrameworkCore;
using Domain.Abstractions.RepositoryInterfaces;
using Domain.Enteties;
using Infrastructure;

namespace WebApplication1.Repositiries
{
    internal class ReportRepository : IReportReposytory
    {
        protected readonly ApplicationDbContext DbContext;
        protected ReportRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Add(Report report)
        {
            DbContext.Reports.Add(report);
        }

        public async Task<List<Report>> GetAllAsync()
        {
            return await DbContext.Reports.ToListAsync();
        }

        public async Task<Report?> GetByIdAsync(Guid id)
        {
            return await DbContext.Reports.FirstOrDefaultAsync(e => e.ReportId == id);

        }

        public void RemoveById(Report report)
        {
            DbContext.Reports.Remove(report);
        }
    }
}
