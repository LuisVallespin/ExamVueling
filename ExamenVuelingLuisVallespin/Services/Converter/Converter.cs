using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ExamenVuelingLuisVallespin.Services.Repository;

namespace ExamenVuelingLuisVallespin.Services.Converter
{
    public class Converter : IConverter
    {
        private readonly IGenericRepository<Rate> _repository;

        public Converter()
        {

        }

        public Converter(IGenericRepository<Rate> repository)
        {
            _repository = repository;
        }

        public async Task<decimal> Convert(decimal amount, string from, string to)
        {
            var listRates = await _repository.GetAll();
            var rate = listRates
                .Where(item => item.From == from)
                .Where(item => item.To == to)
                .First();
            return amount * rate.RateValue;
        }
    }
}