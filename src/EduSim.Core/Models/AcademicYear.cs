using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("academic_years")]
	public class AcademicYear : IAcademicYear
	{
		[Column("pk_academic_year_id")]
		public int AcademicYearId { get; set; }

		[Column("fk_account_id")]
		public int AccountId { get; set; }

		[Column("start_date")]
		public DateTime StartDate { get; set; }

		[Column("end_date")]
		public DateTime EndDate { get; set; }

		public AcademicYear()
		{
		}
	}
}
