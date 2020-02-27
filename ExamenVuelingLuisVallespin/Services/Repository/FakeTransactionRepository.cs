using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public class FakeTransactionRepository : ITransactionRepository
    {
        private List<Transaction> transactionList = new List<Transaction>()
        {
            new Transaction() { Sku = "123SA", Amount = 10.2M, Currency = "EUR"},
            new Transaction() { Sku = "Q5SDF8", Amount = 4.2M, Currency = "USD"},
            new Transaction() { Sku = "SDG41S", Amount = 7.0M, Currency = "CAD"},
            new Transaction() { Sku = "FGD3S", Amount = 13.5M, Currency = "AUS"}
        };

        public async Task<IEnumerable<Transaction>> GetAll()
        {
            return transactionList;
        }

        public async Task<Transaction> GetById(object id)
        {
            return transactionList[(int)id];
        }

        public async Task Add(Transaction entity)
        {
            transactionList.Add(entity);
        }

        public async Task AddAll(IEnumerable<Transaction> entityList)
        {
            foreach (var item in entityList)
            {
                transactionList.Add(item);
            }
        }

        public async Task Update(Transaction entity)
        {
            Transaction transaction = transactionList.Find(item => item.Id == entity.Id);
            if (transaction != null)
            {
                transaction = entity;
            }
            await Save().ConfigureAwait(false);
        }

        public async Task Delete(object id)
        {
            transactionList.RemoveAt((int)id);
        }

        public async Task Empty()
        {
            transactionList = new List<Transaction>();
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Transaction>> GetAllBySku(string sku)
        {
            throw new NotImplementedException();
        }
    }
}