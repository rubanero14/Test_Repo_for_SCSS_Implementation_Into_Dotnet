using System.Web;
using System.Web.Mvc;

namespace Test_Repo_for_SCSS_Implementation_Into_Dotnet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
