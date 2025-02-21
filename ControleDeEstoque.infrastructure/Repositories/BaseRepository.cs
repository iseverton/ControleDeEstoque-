using ControleDeEstoque.Domain.Interfaces;
using ControleDeEstoque.infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseReposity<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();  
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
      return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
       return await _dbSet.FindAsync(id);
    }

    public  async Task RemoveAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public Task<TEntity> SearchByConditionAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
}
