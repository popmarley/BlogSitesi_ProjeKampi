using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
