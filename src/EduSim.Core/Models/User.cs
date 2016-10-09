using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSim.Core.Models
{
	[Table("users")]
	public class User
	{
		[Column("pk_user_id")]
		int UserId { get; set; }

		[Column("fk_account_id")]
		int AccountId { get; set; }

		[Column("fk_school_id")]
		int? SchoolId { get; set; }

		[Column("fk_campus_id")]
		int? CampusId { get; set; }

		[Column("first_name")]
		string FirstName { get; set; }

		[Column("last_name")]
		string LastName { get; set; }

		[Column("email")]
		string Email { get; set; }

		[Column("password")]
		string Password { get; set; }

		[Column("is_admin"), MaxLength(1)]
		string IsAdmin { get; set; }

		[Column("is_instructor"), MaxLength(1)]
		string IsInstructor { get; set; }

		[Column("is_Volunteer"), MaxLength(1)]
		string IsVolunteer { get; set; }

		public User()
		{
		}
	}
}
