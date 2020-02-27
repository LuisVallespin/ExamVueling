using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Repository
{
    public class FakeRateRepository : IGenericRepository<Rate>
    {
        private List<Rate> rateList = new List<Rate>()
        {
            new Rate() { From = "EUR", To = "AUS", RateValue = 0.95M},
            new Rate() { From = "CAD", To = "EUR", RateValue = 23.54M},
            new Rate() { From = "USD", To = "EUR", RateValue = 23.54M},
            new Rate() { From = "CAD", To = "USD", RateValue = 23.54M}
        };


        public async Task<IEnumerable<Rate>> GetAll()
        {
            return rateList;
        }

        public async Task<Rate> GetById(object id)
        {
            return rateList[(int)id];
        }

        public async Task Add(Rate entity)
        {
            rateList.Add(entity);
        }

        public async Task AddAll(IEnumerable<Rate> entityList)
        {
            foreach (var item in entityList)
            {
                rateList.Add(item);
            }
        }

        public async Task Update(Rate entity)
        {
            Rate rate = rateList.Find(item => item.Id == entity.Id);
            if (rate != null)
            {
                rate = entity;
            }
            await Save().ConfigureAwait(false);
        }

        public async Task Delete(object id)
        {
            rateList.RemoveAt((int)id);
        }

        public async Task Empty()
        {
            rateList = new List<Rate>();
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }
    }
}