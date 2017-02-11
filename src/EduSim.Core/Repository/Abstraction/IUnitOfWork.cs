using EduSim.Core.Contexts;
using System;

namespace EduSim.Core.Repository
{
	public interface IUnitOfWork : IDisposable
	{
		EduSimContext EduSimContext { get; }
		int Save();
	}
}
