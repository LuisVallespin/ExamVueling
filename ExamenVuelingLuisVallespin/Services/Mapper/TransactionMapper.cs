using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Exception;
using ExamenVuelingLuisVallespin.Services.Factory;

namespace ExamenVuelingLuisVallespin.Services.Mapper
{
    public class TransactionMapper : ITransactionMapper
    {
        private readonly ITransactionFactory _rateFactory;

        public TransactionMapper()
        {

        }

        public TransactionMapper(ITransactionFactory rateFactory)
        {
            _rateFactory = rateFactory;
        }
        public async Task<Transaction> Map(TransactionJson.Class1 transaction)
        {
            try
            {
                return await _rateFactory.CreateInstance(transaction);
            }
            catch (System.Exception ex)
            {
                throw new TransactionMapperException("Problema al Mapear un elemento", ex);
            }
        }

        public async Task<IEnumerable<Transaction>> Map(IEnumerable<TransactionJson.Class1> transactions)
        {
            try
            {
                var transactionsList = new List<Transaction>();
                foreach (var item in transactions)
                {
                    transactionsList.Add(await _rateFactory.CreateInstance(item));
                }

                return transactionsList;
            }
            catch (System.Exception ex)
            {
                throw new TransactionMapperException("Problema al Mapear una lista", ex);
            }
        }
    }
}