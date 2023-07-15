using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
	public interface IGenericDAL<T> where T : class
	{
		void Insert(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetListAll();
		T GetByID(int id);
		List<T> GetListAll(Expression<Func<T, bool>> filter);
	}
}
