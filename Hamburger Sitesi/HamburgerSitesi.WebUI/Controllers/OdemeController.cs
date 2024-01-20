using Microsoft.AspNetCore.Mvc;

namespace HamburgerSitesi.WebUI.Controllers
{
	public class OdemeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Odeme()
		{
			return View();
		}
	}
}
