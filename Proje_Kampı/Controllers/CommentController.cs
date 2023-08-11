using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);
			return PartialView();
		}
	}
}
