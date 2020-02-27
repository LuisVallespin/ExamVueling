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
    public class RateMapper : IRateMapper
    {
        private readonly IRateFactory _rateFactory;

        public RateMapper()
        {

        }

        public RateMapper(IRateFactory rateFactory)
        {
            _rateFactory = rateFactory;
        }

        public async Task<Rate> Map(RateJson.Class1 rateJson)
        {
            try
            {
                return await _rateFactory.CreateInstance(rateJson);
            }
            catch (System.Exception ex)
            {
                throw new RateMapperException("Error al mapear un Rate", ex);
            }
        }

        public async Task<IEnumerable<Rate>> Map(IEnumerable<RateJson.Class1> rateJson)
        {
            try
            {
                var ratesList = new List<Rate>();
                foreach (var item in rateJson)
                {
                    ratesList.Add(await _rateFactory.CreateInstance(item));
                }

                return ratesList;
            }
            catch (System.Exception ex)
            {
                throw new RateMapperException("Error al mapear una lista de Rates", ex);
            }
        }
    }
}