using System.Web;
using System.Web.Mvc;
using WebMVCAppIoC.Filter;

namespace WebMVCAppIoC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(DependencyResolver.Current.GetService<DebugFilter>());
        }
    }
}
