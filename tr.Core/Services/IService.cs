using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr.Core.Services
{
    public interface IService<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();

        public Task<T> GetById(int id);

        public Task<T> Create(T entity);
        public Task Update(T entity);

        public Task Delete(T entity);
    }
}
