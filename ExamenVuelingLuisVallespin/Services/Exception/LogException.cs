using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class LogException : System.Exception
    {
        public LogException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}