using EduSim.Core.Contexts;
using System;

namespace EduSim.Core.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private EduSimContext _eduSimContext;


		public UnitOfWork()
		{
			
		}

		public EduSimContext EduSimContext
		{
			get
			{
				if (_eduSimContext == null)
				{
					_eduSimContext = new EduSimContext();
				}
				return _eduSimContext;
			}
		}

		public int Save()
		{
			return _eduSimContext.SaveChanges();
		}

		public void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_eduSimContext != null)
				{
					_eduSimContext.Dispose();
					_eduSimContext = null;
				}
			}
			GC.SuppressFinalize(this);
		}

		public void Dispose()
		{

		}
	}
}
