using Microsoft.AspNetCore.Mvc;

namespace AddSomeShopWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SystemSettingsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
