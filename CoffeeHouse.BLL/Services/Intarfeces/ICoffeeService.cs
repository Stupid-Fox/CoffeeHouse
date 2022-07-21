using CoffeeHouse.BLL.Models;

namespace CoffeeHouse.BLL.Services.Intarfeces
{    
    public interface IGenericService<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAll();
        Task<TModel> GetById(int id);
        Task Create(TModel item);
        Task Update(TModel item);
        Task Delete(int id);
    }
}
