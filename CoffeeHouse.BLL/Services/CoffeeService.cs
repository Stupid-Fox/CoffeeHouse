﻿using AutoMapper;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Models;

namespace CoffeeHouse.BLL.Services
{
     public class GenericService<TModel, TEntity> : IGenericService<TModel>
         where TModel : class
         where TEntity : class
     {
            private readonly IGenericRepository<TEntity> _repository;

            private readonly IMapper _mapper;

            public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<TModel>> GetAll()
            {
                return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TModel>>(await _repository.GetAll());
            }

            public async Task<TModel> GetById(int id)
            {
                TEntity item = await _repository.GetById(id);

                if (item == null)
                    throw new ArgumentNullException("Object doesn't exist");
                else
                    return _mapper.Map<TEntity, TModel>(item);
            }

            public async Task Create(TModel item)
            {
                await _repository.Create(_mapper.Map<TModel, TEntity>(item));
            }

            public async Task Update(TModel item)
            {
                await _repository.Update(_mapper.Map<TModel, TEntity>(item));
            }

            public async Task Delete(int id)
            {
                TEntity pet = await _repository.GetById(id);

                if (pet == null)
                    throw new ArgumentNullException("Object doesn't exist");
                else
                    _repository.Delete(id);
            }

        }
    
}
