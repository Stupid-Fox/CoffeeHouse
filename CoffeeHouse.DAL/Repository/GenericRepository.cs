using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Controllers;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly CoffeeContext _context;

        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(CoffeeContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Create(TEntity item)
        {
            await _dbSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public async Task Delete(int id)
        {
            TEntity item = (await _dbSet.FindAsync(id))!;
            _dbSet.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
