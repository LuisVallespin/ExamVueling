using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamenVuelingLuisVallespin.Services.Logger;

namespace ExamenVuelingLuisVallespin.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILog _log;

        public ErrorController()
        {

        }

        public ErrorController(ILog log)
        {
            _log = log;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is InvalidOperationException)
            {
                //Logging Errors 
                var errorMessage = filterContext.Exception.Message;
                var controllerName = filterContext.RouteData.Values["controller"].ToString();
                var actionName = filterContext.RouteData.Values["action"].ToString();
                //Log.loggerFile.Debug(errorMessage, controllerName, actionName);
                _log.WriteToLog($"Error: {errorMessage} \n En el controlador: {controllerName} y acción: {actionName}");
                
            }

        }
    }
}