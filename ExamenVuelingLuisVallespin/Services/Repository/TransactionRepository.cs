using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Transaction> _table;

        public TransactionRepository()
        {

        }

        public TransactionRepository(GNBSalesContainer context)
        {
            _context = context;
            _table = context.Set<Transaction>();
        }

        public async Task<IEnumerable<Transaction>> GetAll()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }

        public async Task<Transaction> GetById(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        public async Task Add(Transaction entity)
        {
            _table.Add(entity);
            await Save().ConfigureAwait(false);
        }

        public async Task AddAll(IEnumerable<Transaction> entityList)
        {
            foreach (var item in entityList)
            {
                _table.Add(item);
                await Save().ConfigureAwait(false);
            }
        }

        public async Task Update(Transaction entity)
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

        public async Task<IEnumerable<Transaction>> GetAllBySku(string sku)
        {
            return await _table.Where(item => item.Sku == sku).ToListAsync().ConfigureAwait(false);
        }
    }
}