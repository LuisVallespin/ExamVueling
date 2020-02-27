using System.Web;
using System.Web.Mvc;

namespace ExamenVuelingLuisVallespin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
