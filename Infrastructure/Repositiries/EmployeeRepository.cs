using Microsoft.EntityFrameworkCore;
using Domain.Abstractions.RepositoryInterfaces;
using Domain.Enteties;
using Infrastructure;


namespace WebApplication1.Repositiries
{
    internal class EmployeeRepository : IEmployeeReposytory
    {
        protected readonly ApplicationDbContext DbContext;
        protected EmployeeRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Add(Employee employee)
        {
            DbContext.Employees.Add(employee);

        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await DbContext.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await DbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
        }

        public void RemoveById(Employee employee)
        {
            DbContext.Employees.Remove(employee);
        }

        public void Update(Employee employee)
        {
            DbContext.Employees.Update(employee);
        }
    }
}
