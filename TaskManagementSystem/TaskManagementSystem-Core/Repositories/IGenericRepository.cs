using System.Linq.Expressions;
using TaskManagementSystem_Core.Entities.Common;

namespace TaskManagementSystem_Core.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAll();
    Task<T?> GetByIdAsync(int id);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
    Task<bool> IsExistAsync(int id);
    Task<bool> IsExistAsync(Expression<Func<T, bool>> expression);
    Task AddAsync(T entity);
    Task<int> SaveAsync();
    void Delete(T entity);
}