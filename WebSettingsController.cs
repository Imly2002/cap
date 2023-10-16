using Microsoft.AspNetCore.Mvc;

namespace AddSomeShopWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class WebSettingsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
