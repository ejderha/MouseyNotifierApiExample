using System.Web;
using System.Web.Mvc;

namespace Forservices.MOUSEY.Notifier.WebAPI.Example
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
