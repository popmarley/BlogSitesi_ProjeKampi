using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm=new WriterManager (new EFWriterRepository ());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p)
		{
			p.WriterStatus = true;
			p.WriterAbout = "deneme test";
			wm.WriterAdd(p);
			 return RedirectToAction("Index","Blog");
		}
	}
}
