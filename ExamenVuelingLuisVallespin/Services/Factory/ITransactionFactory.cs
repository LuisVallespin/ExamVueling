using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Factory
{
    public interface ITransactionFactory
    {
        Task<Transaction> CreateInstance(TransactionJson.Class1 transaction);
    }
}
