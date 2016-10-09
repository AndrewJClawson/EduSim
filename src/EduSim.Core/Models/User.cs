using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("users")]
	public class User : IUser
	{
		
		[Column("pk_user_id")]
		public int UserId { get; set; }

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

		[Column("email")]
		public string Email { get; set; }

		[Column("password")]
		public string Password { get; set; }

		[Column("is_admin"), MaxLength(1)]
		public string IsAdmin { get; set; }

		[Column("is_instructor"), MaxLength(1)]
		public string IsInstructor { get; set; }

		[Column("is_Volunteer"), MaxLength(1)]
		public string IsVolunteer { get; set; }

		public virtual Account Account { get; set; }
		public virtual School School { get; set; }

		public User()
		{
		}
	}
}
