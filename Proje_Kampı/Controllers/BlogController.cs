using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm=new BlogManager(new EFBlogRepository());
		public IActionResult Index()
		{
			var values =bm.GetList();
			return View(values);
		}
	}
}
