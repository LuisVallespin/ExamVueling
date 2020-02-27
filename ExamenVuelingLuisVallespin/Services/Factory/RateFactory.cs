using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebPages;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Exception;

namespace ExamenVuelingLuisVallespin.Services.Factory
{
    public class RateFactory : IRateFactory
    {
        public async Task<Rate> CreateInstance(RateJson.Class1 rate)
        {
            try
            {
                return await Task.Run(() => new Rate()
                {
                    From = rate.from,
                    To = rate.to,
                    RateValue = Convert.ToDecimal(rate.rate)
                });
            }
            catch (System.Exception ex)
            {
                throw new RateFactoryException("Hubo un problema al crear un objeto Rate", ex);
            }
            
        }
    }
}