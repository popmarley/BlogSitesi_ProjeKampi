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
	public class WriterManager:IWriterService
	{
		IWriterDAL _writerDAL;

		public WriterManager(IWriterDAL writerDAL)
		{
			_writerDAL = writerDAL;
		}

		public void WriterAdd(Writer writer)
		{
			_writerDAL.Insert(writer);
		}
	}
}
