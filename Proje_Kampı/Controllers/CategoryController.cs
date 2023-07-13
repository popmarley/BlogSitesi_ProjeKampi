using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager cm= new CategoryManager(new EFCategoryRepository());
		public IActionResult Index()
		{
			var values = cm.GetList();
			return View(values);
		}
	}
}
