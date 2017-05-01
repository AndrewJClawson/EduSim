using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("academic_years")]
	public class AcademicYear : IAcademicYear
	{
		[Column("start_date")]
		public DateTime StartDate { get; set; }

		[Column("end_date")]
		public DateTime EndDate { get; set; }

		public AcademicYear()
		{
		}
	}
}
