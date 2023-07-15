using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
	public class EFBlogRepository : GenericRepository<Blog>, IBlogDAL
	{
		public List<Blog> GetListWithCategory()
		{
			using(var c = new Context())
			{
				return c.Blogs.Include(b => b.Category).ToList();
			}
			
		}
	}
}
