using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Interfaces;

public interface IBaseReposity<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> SearchByConditionAsync(Expression<Func<TEntity, bool>> predicate);

    Task<TEntity> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task RemoveAsync(TEntity entity);
}
