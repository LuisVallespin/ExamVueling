using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebPages;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Factory
{
    public class RateFactory : IRateFactory
    {
        public async Task<Rate> CreateInstance(RateJson.Class1 rate)
        {
            return await Task.Run(() => new Rate()
            {
                From = rate.from,
                To = rate.to,
                RateValue = Convert.ToDecimal(rate.rate) 
            });
        }
    }
}