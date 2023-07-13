using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
