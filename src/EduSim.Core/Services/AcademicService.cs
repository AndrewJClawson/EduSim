using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.Contexts;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Models;
namespace EduSim.Core.Services
{
	public class AcademicService : IAcademicService
	{
		EduSimContext _context;
		public AcademicService(EduSimContext context)
		{
			_context = context;
		}

		public IEnumerable<AcademicYear> GetAcademicYearsForAccount(int accountId)
		{
			return _context.AcademicYears
				           .Where(a => a.AccountId == accountId);
		}
	}
}
