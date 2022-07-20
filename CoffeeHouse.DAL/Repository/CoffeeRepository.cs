using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Controllers;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        CoffeeContext _context;
        DbSet<TEntity> _dbSet;

        public GenericRepository(CoffeeContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity FindById(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new ArgumentNullException("Object cannot be null", nameof(entity));
            }             
            return entity;      
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            if (_dbSet == null)
            {
                throw new ArgumentNullException("Object cannot be null", nameof(_dbSet));
            }
            _context.SaveChanges();
        }
    }
}
