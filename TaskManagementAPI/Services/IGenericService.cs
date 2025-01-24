using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace TaskManagementAPI.Services
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = "");

        Task<TEntity?> GetByIdAsync(Guid id);

        Task AddAsync(TEntity entity);

        Task DeleteAsync(
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setProperty,
        Expression<Func<TEntity, bool>> filter);

        Task UpdateAsync(
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setProperty,
        Expression<Func<TEntity, bool>>? filter = null);
    }
}