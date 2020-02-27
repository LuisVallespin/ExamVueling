using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class TransactionMapperException : System.Exception
    {
        public TransactionMapperException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    
    }
}