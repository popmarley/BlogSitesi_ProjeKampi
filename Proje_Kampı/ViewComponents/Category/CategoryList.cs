using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Kampı.ViewComponents.Category
{
	public class CategoryList: ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EFCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);
		}
	}
}
