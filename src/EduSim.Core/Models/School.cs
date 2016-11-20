using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("schools")]
	public class School : ISchool
	{
		[Column("pk_school_id")]
		public int SchoolId { get; set; }

		[Column("fk_account_id")]
		public int AccountId { get; set; }

		[Column("name")]
		public string SchoolName { get; set; }

		[Column("address")]
		public string Address { get; set; }

		[Column("city")]
		public string City { get; set; }

		[Column("state")]
		public string State { get; set; }

		[Column("zip")]
		public string Zip { get; set; }

		public virtual Account Account { get; set; }

		public virtual ICollection<Profile> Profiles { get; set; }

	}
}
