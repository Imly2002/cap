using Microsoft.AspNetCore.Mvc;

namespace AddSomeShopWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SalesController : Controller
	{
		public IActionResult PriceCheck()
		{
			return View();
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Returnandrefund()
		{
			return View();
		}

		public IActionResult Payment()
		{
			return View();
		}
		public IActionResult Addproduct()
		{
			return View();
		}
	}
}
