using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class SumOfAllProductsExceptions : System.Exception
    {
        public SumOfAllProductsExceptions(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}