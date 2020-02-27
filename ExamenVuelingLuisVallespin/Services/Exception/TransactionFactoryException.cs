using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class TransactionFactoryException : System.Exception
    {
        public TransactionFactoryException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}