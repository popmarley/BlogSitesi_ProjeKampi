using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm =new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList(4);
			return View(values);
		}
	}
}
