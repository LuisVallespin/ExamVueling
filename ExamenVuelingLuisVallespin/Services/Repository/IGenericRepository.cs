using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task Add(T entity);
        Task AddAll(IEnumerable<T> entityList);
        Task Update(T entity);
        Task Delete(object id);
        Task Empty();
        Task Save();
    }
}
