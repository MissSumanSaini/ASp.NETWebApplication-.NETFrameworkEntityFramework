using System.Web;
using System.Web.Mvc;

namespace ASp.NETWebApplication_.NETFrameworkEntityFramework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
