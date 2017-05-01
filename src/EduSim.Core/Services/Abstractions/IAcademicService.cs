using System;
using System.Collections.Generic;
using EduSim.Core.Models;

namespace EduSim.Core.Services
{
	public interface IAcademicService
	{
		IEnumerable<AcademicYear> GetAcademicYearsForAccount(int accountId);
	}
}
