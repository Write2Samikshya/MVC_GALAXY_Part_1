using System.Web;
using System.Web.Mvc;

namespace Samikshya_MVC_Products_App1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
