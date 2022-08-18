using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Repositories;
using tr.Core.Services;

namespace tr.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> repository;

        public Service(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public async Task<T> Create(T entity)
        {
            await repository.Create(entity);

            return entity;
        }

        public async Task Delete(T entity)
        {
            repository.Delete(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var veriler = await repository.GetAll().ToListAsync();
            return veriler;
        }

        public async Task<T> GetById(int id)
        {
            var veri = await repository.GetByIdAsync(id);
            return veri;
        }

        public async Task Update(T entity)
        {
            repository.Update(entity);
        }
    }
}
