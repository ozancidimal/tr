using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Repositories;
using tr.Repository.AppDbContext;

namespace tr.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly trDbContext _context;
        private readonly DbSet<T> _dBset;
        public Repository(trDbContext context)
        {
            _context = context;
            _dBset = _context.Set<T>();
        }

        public async Task Create(T Entity)
        {
            await _dBset.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _dBset.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dBset.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dBset.FindAsync(id);
        }

        public void Update(T entity)
        {
            _dBset.Update(entity);
            _context.SaveChanges();
        }
    }

}
