using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Factory
{
    public class TransactionFactory : ITransactionFactory
    {
        public async Task<Transaction> CreateInstance(TransactionJson.Class1 transaction)
        {
            return await Task.Run(() => new Transaction()
            {
                Sku = transaction.sku,
                Amount = Convert.ToDecimal(transaction.amount),
                Currency = transaction.currency
            });
        }
    }
}