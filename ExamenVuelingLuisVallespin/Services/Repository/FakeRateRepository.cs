using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public class FakeRateRepository : IGenericRepository<Rate>
    {
        private readonly List<Rate> rateList = new List<Rate>()
        {
            new Rate() { From = "EUR", To = "AUS", RateValue = 0.95M},
            new Rate() { From = "CAD", To = "EUR", RateValue = 23.54M},
            new Rate() { From = "USD", To = "EUR", RateValue = 23.54M},
            new Rate() { From = "CAD", To = "USD", RateValue = 23.54M}
        };


        public Task<IEnumerable<Rate>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Rate> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Rate entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAll(IEnumerable<Rate> entityList)
        {
            throw new NotImplementedException();
        }

        public Task Update(Rate entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task Empty()
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}