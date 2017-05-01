using System;

namespace EduSim.Core.ModelInterfaces
{
	public interface IAcademicYear
	{
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }
	}
}
