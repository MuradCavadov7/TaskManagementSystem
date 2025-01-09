using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaskManagementSystem_Core.Entities.Common;
using TaskManagementSystem_Core.Repositories;
using TaskManagementSystem_DAL.Contexts;

namespace TaskManagementSystem_DAL.Repositories
{
    public class GenericRepository<T>(TaskManagementSystemDbContext _context) : IGenericRepository<T> where T : BaseEntity, new()
    {
        protected DbSet<T> Table => _context.Set<T>();
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public IQueryable<T> GetAll()
            => Table.AsQueryable();


        public async Task<T?> GetByIdAsync(int id)
            => await Table.FindAsync(id);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => Table.Where(predicate).AsQueryable();


        public async Task<bool> IsExistAsync(int id)
            => await Table.AnyAsync(x => x.Id == id);

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public async Task<bool> IsExistAsync(Expression<Func<T, bool>> expression)
            => await Table.AnyAsync(expression);
    }
}
