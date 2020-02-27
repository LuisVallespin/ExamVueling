using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Deserializer;
using ExamenVuelingLuisVallespin.Services.Factory;
using ExamenVuelingLuisVallespin.Services.Mapper;
using ExamenVuelingLuisVallespin.Services.Repository;
using ExamenVuelingLuisVallespin.Services.UrlChecker;

namespace ExamenVuelingLuisVallespin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //AutoFac
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<GNBSalesContainer>();
            builder.RegisterType<GenericRepository<Rate>>().As<IGenericRepository<Rate>>();
            builder.RegisterType<TransactionRepository>().As<ITransactionRepository>();
            builder.RegisterType<UrlChecker>().As<IUrlChecker>();
            builder.RegisterType<GenericDeserializer<RateJson.Class1>>().As<IGenericDeserializer<RateJson.Class1>>();
            builder.RegisterType<RateMapper>().As<IRateMapper>();
            builder.RegisterType<RateFactory>().As<IRateFactory>();
            builder.RegisterType<TransactionFactory>().As<ITransactionFactory>();
            builder.RegisterType<GenericDeserializer<TransactionJson.Class1>>().As<IGenericDeserializer<TransactionJson.Class1>>();
            builder.RegisterType<TransactionMapper>().As<ITransactionMapper>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
