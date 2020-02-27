using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Products
{
    public interface ISumOfAllProducts
    {
        Task<Dictionary<string, decimal>> Get();
    }
}
