using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Mapper
{
    public interface IRateMapper
    {
        Task<Rate> Map(RateJson.Class1 rateJson);
        Task<IEnumerable<Rate>> Map(IEnumerable<RateJson.Class1> ratesJson);
    }
}
