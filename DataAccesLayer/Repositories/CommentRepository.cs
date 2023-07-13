using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
	public class CommentRepository : IGenericDAL<Comment>
	{
		public void Delete(Comment t)
		{
			throw new NotImplementedException();
		}

		public Comment GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetListAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Comment t)
		{
			throw new NotImplementedException();
		}

		public void Update(Comment t)
		{
			throw new NotImplementedException();
		}
	}
}
