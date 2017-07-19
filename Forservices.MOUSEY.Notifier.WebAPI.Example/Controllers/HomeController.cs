using System.Web.Mvc;

namespace Forservices.MOUSEY.Notifier.WebAPI.Example.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}
	}
}
