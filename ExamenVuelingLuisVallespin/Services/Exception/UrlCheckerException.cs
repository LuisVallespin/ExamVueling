﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenVuelingLuisVallespin.Services.Exception
{
    public class UrlCheckerException : System.Exception
    {
        public UrlCheckerException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}