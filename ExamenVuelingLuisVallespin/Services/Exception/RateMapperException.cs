using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class RateMapperException : System.Exception
    {
        public RateMapperException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}