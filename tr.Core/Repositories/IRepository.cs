using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        public Task<T> GetByIdAsync(int id);
        public IQueryable<T> GetAll();

        public Task Create(T entity);

        public void Update(T entity);

        public void Delete(T entity);
    }
}
