using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetAllBySku(string sku);
    }
}
