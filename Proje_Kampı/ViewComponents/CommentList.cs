using Microsoft.AspNetCore.Mvc;
using Proje_Kampı.Models;
using System.Collections.Generic;

namespace Proje_Kampı.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{ new UserComment
			{
				ID = 1,
				Username = "Hüseyin",
			},
			new UserComment {
				ID = 2,
			    Username="Deneme"
			}

			};
			return View(commentvalues);
		}
	}
}
