using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Factory
{
    public interface IRateFactory
    {
        Task<Rate> CreateInstance(RateJson.Class1 rate);
    }
}
