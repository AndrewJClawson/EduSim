using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;
using System.Security;

namespace EduSim.Core.Models
{
	[Table("profiles")]
	public class Profile : IProfile
	{
		[Column("pk_profile_id")]
		public int ProfileId { get; set; }
		
		[Column("fk_user_id")]
		public string UserId { get; set; }

		[Column("fk_account_id")]
		public int AccountId { get; set; }

		[Column("fk_school_id")]
		public int? SchoolId { get; set; }

		[Column("fk_campus_id")]
		public int? CampusId { get; set; }

		[Column("first_name")]
		public string FirstName { get; set; }

		[Column("last_name")]
		public string LastName { get; set; }

		public virtual Account Account { get; set; }
		public virtual School School { get; set; }

		public virtual ICollection<Role> Roles { get; set;}

		public Profile()
		{
		}
	}
}
