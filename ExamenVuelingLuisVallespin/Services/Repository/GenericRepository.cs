using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _table;

        public GenericRepository(GNBSalesContainer context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }

        public async Task<T> GetById(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        public async Task Add(T entity)
        {
            _table.Add(entity);
            await Save().ConfigureAwait(false);
        }

        public async Task AddAll(IEnumerable<T> entityList)
        {
            foreach (var item in entityList)
            {
                _table.Add(item);
                await Save().ConfigureAwait(false);
            }
            
        }

        public async Task Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await Save().ConfigureAwait(false);
        }

        public async Task Delete(object id)
        {
            var existingObject = await _table.FindAsync(id).ConfigureAwait(false);
            if (existingObject != null)
            {
                _table.Remove(existingObject);
                await Save().ConfigureAwait(false);
            }

        }

        public async Task Empty()
        {
            _table.RemoveRange(_table);
            await Save();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}