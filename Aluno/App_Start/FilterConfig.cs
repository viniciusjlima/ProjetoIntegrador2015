using System.Web;
using System.Web.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Aluno
{
    public class FilterConfig
    {
        [ExcludeFromCodeCoverage]
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}