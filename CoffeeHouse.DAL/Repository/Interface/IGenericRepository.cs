using CoffeeHouse.DAL.Models;

namespace CoffeeHouse.DAL.Controllers
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity FindById(int id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Remove(TEntity item);
       
    }
}