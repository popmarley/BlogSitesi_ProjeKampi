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
	public class CommentManager : ICommentService
	{
		ICommentDAL _commentdal;

		public CommentManager(ICommentDAL commentdal)
		{
			_commentdal = commentdal;
		}

		public void CommentAdd(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{
			return _commentdal.GetListAll(x => x.BlogID == id);
		}
	}
}
