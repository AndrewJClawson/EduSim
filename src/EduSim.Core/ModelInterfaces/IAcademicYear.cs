using System;

namespace EduSim.Core.ModelInterfaces
{
	public interface IAcademicYear
	{
		int AcademicYearId { get; set; }
		int AccountId { get; set; }
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }
	}
}
