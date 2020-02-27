using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class DeserializerException : System.Exception
    {
        public DeserializerException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}