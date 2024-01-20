using Microsoft.AspNetCore.Mvc;

namespace HamburgerSitesi.WebUI.Controllers
{
    public class MenuController : Controller
    {
		
		public IActionResult Index()
        {
			return View();
        }
		
        public IActionResult Menu()
        {
			return View();
        }

    }
}
