using CoffeeHouse.DAL.Models;

namespace CoffeeHouse.DAL.Controllers
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity item);
        Task Update(TEntity item);
        Task Delete(int id);

    }
}