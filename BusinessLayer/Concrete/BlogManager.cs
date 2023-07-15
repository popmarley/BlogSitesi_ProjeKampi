using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDAL _blogDAL;

		public BlogManager(IBlogDAL blogDAL)
		{
			_blogDAL = blogDAL;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public Blog GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetList()
		{
			return _blogDAL.GetListAll();
		}
	}
}
