using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_4_Web_Applications_Jump_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}