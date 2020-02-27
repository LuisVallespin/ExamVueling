using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Mapper
{
    public interface ITransactionMapper
    {
        Task<Transaction> Map(TransactionJson.Class1 transaction);
        Task<IEnumerable<Transaction>> Map(IEnumerable<TransactionJson.Class1> transactions);
    }
}
