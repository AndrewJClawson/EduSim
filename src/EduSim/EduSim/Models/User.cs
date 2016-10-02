using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.Entity;
using EduSim.ModelInterfaces;
//using MySql.Data.Entity;


namespace EduSim.Models
{
	[Table("users")]
	public class User
	{
		[Column("pk_user_id")]
		public int UserId { get; set;}

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

		[Column("is_admin")]
		public string IsAdmin { get; set; }

		[Column("is_instructor")]
		public string IsInstructor { get; set; }

		[Column("is_volunteer")]
		public string IsVolunteer { get; set; }




		//Constructor
		public User()
		{
			
		}

		public virtual Account Account { get; set; }
	}
}

